using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

namespace ArduinoRemoteCar
{
    public partial class Form1 : Form
    {
        public delegate void AddDataDelegate();
        public Form1()
        {
            InitializeComponent();
            string[] GetPorts = SerialPort.GetPortNames();
            int[] BaudRate = new[] { 115200 ,9600, 19200, 38400, 57600, 230400, 250000 };
            cb_port.DataSource = GetPorts;
            cb_baud.DataSource = BaudRate;
        }

        public class Motor
        {
            public static int motA_PWM = 100;
            public static int motB_PWM = 100;
        }

        public class Servo_deg //Servo motor degree
        {
            public static int servo1 = 0;
            public static int servo2 = 0;
            public static int servo3 = 0;
            public static int servo4 = 0;
            public static int servo1_home = 100;
            public static int servo2_home = 100;
            public static int servo3_home = 100;
            public static int servo4_home = 100;
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new AddDataDelegate(AddData));
        }

        private void AddData() //Receive data from serial
        {
            string dataLine = serialPort1.ReadLine();
            tb_received.Text = dataLine;
        }

        #region Connection part

        private void bt_rescan_Click(object sender, EventArgs e)
        {
            string[] GetPorts = SerialPort.GetPortNames();
            cb_port.DataSource = GetPorts;
        }

        private void bt_monitor_Click(object sender, EventArgs e)
        {

        }

        private void bt_conn_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cb_port.SelectedItem.ToString();  //Set COM port
                serialPort1.BaudRate = Convert.ToInt32(cb_baud.SelectedItem.ToString()); //Set baudrate
                if (!serialPort1.IsOpen)
                {
                   
                    bt_conn.Enabled = false;
                    serialPort1.Open();
                    lb_conn_state.Text = "Connected";
                    lb_conn_state.ForeColor = Color.Green;
                    serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                    this.KeyPreview = true;
                    //control part
                    bt_disc.Enabled = true;
                    bt_conn.Enabled = false;
                    bt_stop.Enabled = true;
                    bt_forward.Enabled = true;
                    bt_back.Enabled = true;
                    bt_left.Enabled = true;
                    bt_right.Enabled = true;
                    //arm part
                    bt_arm_fw.Enabled = true;
                    bt_arm_back.Enabled = true;
                    bt_arm_left.Enabled = true;
                    bt_arm_right.Enabled = true;
                    bt_stop.Enabled = true;
                    bt_homing.Enabled = true;
                    tbar_servo1.Enabled = true;
                    tbar_servo2.Enabled = true;
                    tbar_servo3.Enabled = true;
                    tbar_servo4.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Serial port open error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lb_conn_state.Text = "Error!";
                lb_conn_state.ForeColor = Color.Red;
            }
        }

        private void bt_disc_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                lb_conn_state.Text = "Disconnected";
                lb_conn_state.ForeColor = Color.Red;
                bt_disc.Enabled = false;
                bt_conn.Enabled = true;
                //control part
                bt_forward.Enabled = false;
                bt_back.Enabled = false;
                bt_left.Enabled = false;
                bt_right.Enabled = false;
                bt_stop.Enabled = false;
                bt_homing.Enabled = false;
                //arm part
                bt_arm_fw.Enabled = false;
                bt_arm_back.Enabled = false;
                bt_arm_left.Enabled = false;
                bt_arm_right.Enabled = false;
                bt_stop.Enabled = true;
                bt_homing.Enabled = true;
                tbar_servo1.Enabled = false;
                tbar_servo2.Enabled = false;
                tbar_servo3.Enabled = false;
                tbar_servo4.Enabled = false;
                this.KeyPreview = false;
            }
        }

        #endregion

        private void Send_cmd(string cmd)
        {
            if (!serialPort1.IsOpen) return;
            serialPort1.Write(cmd + "\n");
        }

        private void Send_cmd_nr(string cmd)
        {
            if (!serialPort1.IsOpen) return;
            serialPort1.Write(cmd);
        }

        #region Motor control

        private void Update_PWM()
        {
            lb_motA_PWM.Text = Convert.ToString(Motor.motA_PWM);
            lb_motB_PWM.Text = Convert.ToString(Motor.motB_PWM);
            Send_cmd("A" + Motor.motA_PWM);
            Send_cmd("B" + Motor.motB_PWM);
        }

        private void tbar_motA_Scroll(object sender, EventArgs e)
        {
            Motor.motA_PWM = tbar_motA.Value;
        }

        private void tbar_motB_Scroll(object sender, EventArgs e)
        {
            Motor.motB_PWM = tbar_motB.Value;
        }

        #endregion

        #region Button Click

        private void Soft_STOP()
        {
            Send_cmd("A0");
            Send_cmd("B0");
            lb_motA_PWM.Text = "0";
            lb_motB_PWM.Text = "0";
        }

        private void bt_stop_Click(object sender, EventArgs e)
        {
            Send_cmd("S");
            lb_motA_PWM.Text = "0";
            lb_motB_PWM.Text = "0";
        }

        private void bt_forward_MouseDown(object sender, MouseEventArgs e)
        {
            bt_forward.ForeColor = Color.Yellow;
            Update_PWM();
            Send_cmd("F");
        }

        private void bt_forward_MouseUp(object sender, MouseEventArgs e)
        {
            bt_forward.ForeColor = SystemColors.ControlText;
            Soft_STOP();
        }

        private void bt_back_MouseDown(object sender, MouseEventArgs e)
        {
            bt_back.ForeColor = Color.Yellow;
            Update_PWM();
            Send_cmd("C");
        }

        private void bt_back_MouseUp(object sender, MouseEventArgs e)
        {
            bt_back.ForeColor = SystemColors.ControlText;
            Soft_STOP();
        }

        private void bt_left_MouseDown(object sender, MouseEventArgs e)
        {
            bt_left.ForeColor = Color.Yellow;
            Update_PWM();
            Send_cmd("L");
        }

        private void bt_left_MouseUp(object sender, MouseEventArgs e)
        {
            bt_left.ForeColor = SystemColors.ControlText;
            Soft_STOP();
        }

        private void bt_right_MouseDown(object sender, MouseEventArgs e)
        {
            bt_right.ForeColor = Color.Yellow;
            Update_PWM();
            Send_cmd("R");
        }

        private void bt_right_MouseUp(object sender, MouseEventArgs e)
        {
            bt_right.ForeColor = SystemColors.ControlText;
            Soft_STOP();
        }

        private void bt_arm_fw_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void bt_arm_fw_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void bt_arm_left_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void bt_arm_left_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void bt_arm_right_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void bt_arm_right_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void bt_arm_back_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void bt_arm_back_MouseUp(object sender, MouseEventArgs e)
        {

        }


        #endregion

        #region Keyboard input

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //Direction control
            if (e.KeyCode == Keys.S)
            {
                bt_stop_Click(null, null);
            }
            else if (e.KeyCode == Keys.Up)
            {
                bt_forward_MouseDown(null, null);
            }
            else if (e.KeyCode == Keys.Down)
            {
                bt_back_MouseDown(null, null);
            }
            else if (e.KeyCode == Keys.Left)
            {
                bt_left_MouseDown(null, null);
            }
            else if (e.KeyCode == Keys.Right)
            {
                bt_right_MouseDown(null, null);
            }
            //Arm control
            if (e.KeyCode == Keys.A)
            {
                bt_arm_left_MouseDown(null, null);
            }
            else if (e.KeyCode == Keys.W)
            {
                bt_arm_fw_MouseDown(null, null);
            }
            else if (e.KeyCode == Keys.S)
            {
                bt_arm_back_MouseDown(null, null);
            }
            else if (e.KeyCode == Keys.D)
            {
                bt_arm_right_MouseDown(null, null);
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //Direction control
            if (e.KeyCode == Keys.Up)
            {
                bt_forward_MouseUp(null, null);
            }
            else if (e.KeyCode == Keys.Down)
            {
                bt_back_MouseUp(null, null);
            }
            else if (e.KeyCode == Keys.Left)
            {
                bt_left_MouseUp(null, null);
            }
            else if (e.KeyCode == Keys.Right)
            {
                bt_right_MouseUp(null, null);
            }
            //Arm control
            if (e.KeyCode == Keys.A)
            {
                bt_arm_left_MouseUp(null,null);
            }
            else if (e.KeyCode == Keys.W)
            {
                bt_arm_fw_MouseUp(null, null);
            }
            else if (e.KeyCode == Keys.S)
            {
                bt_arm_back_MouseUp(null, null);
            }
            else if (e.KeyCode == Keys.D)
            {
                bt_arm_right_MouseUp(null, null);
            }
        }

        #endregion


        #region Bar pull

        private void tbar_servo1_Scroll(object sender, EventArgs e)
        {
            Servo_deg.servo1 = tbar_servo1.Value;
            lb_sv1_deg.Text = Convert.ToString(tbar_servo1.Value);
            Send_cmd_nr("1:");
            Send_cmd(Convert.ToString(tbar_servo1.Value));

        }

        private void tbar_servo2_Scroll(object sender, EventArgs e)
        {
            Servo_deg.servo2 = tbar_servo2.Value;
            lb_sv2_deg.Text = Convert.ToString(tbar_servo2.Value);
            Send_cmd_nr("2:");
            Send_cmd(Convert.ToString(tbar_servo2.Value));
        }

        private void tbar_servo3_Scroll(object sender, EventArgs e)
        {
            Servo_deg.servo3 = tbar_servo3.Value;
            lb_sv3_deg.Text = Convert.ToString(tbar_servo3.Value);
            Send_cmd_nr("3:");
            Send_cmd(Convert.ToString(tbar_servo3.Value));
        }

        private void tbar_servo4_Scroll(object sender, EventArgs e)
        {
            Servo_deg.servo4 = tbar_servo4.Value;
            lb_sv4_deg.Text = Convert.ToString(tbar_servo4.Value);
            Send_cmd_nr("4:");
            Send_cmd(Convert.ToString(tbar_servo4.Value));
        }

        #endregion

    }

}
