using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace ArduinoRemoteCar
{
    public partial class Form1 : Form
    {

        string serialData;

        public Form1()
        {
            InitializeComponent();

            cb_port.DataSource = SerialComm.Connection_info.GetPorts;
            cb_baud.DataSource = SerialComm.Connection_info.BaudRate;
        }

        // 建立車與手臂物件
        Car car = new Car();
        Arm arm = new Arm();

        bool mt_sync = false;

        #region Connection part

        private void bt_rescan_Click(object sender, EventArgs e)
        {

            cb_port.DataSource =  SerialPort.GetPortNames();
        }

        private void bt_monitor_Click(object sender, EventArgs e)
        {
            //TODO: Serial Monitor Window
        }

        private void bt_conn_Click(object sender, EventArgs e)
        {
            try
            {
                SerialComm.port = cb_port.SelectedItem.ToString();
                SerialComm.baud = Convert.ToInt32(cb_baud.SelectedItem.ToString());
               // if (!SerialComm.Connected())
                //{
                    bt_conn.Enabled = false;
                    SerialComm.Connect();
                    if(SerialComm.Connected())
                    {
                        lb_conn_state.Text = "Connected";
                        lb_conn_state.ForeColor = Color.Green;
                         #region Button_enable
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
                    bt_arm_grasp.Enabled = true;
                    bt_arm_up.Enabled = true;
                    bt_arm_down.Enabled = true;
                    bt_stop.Enabled = true;
                    bt_homing.Enabled = true;
                    tbar_servo1.Enabled = true;
                    tbar_servo2.Enabled = true;
                    tbar_servo3.Enabled = true;
                    tbar_servo4.Enabled = true;
#endregion
                    }
                //}
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
            if (SerialComm.Connected())
            {
                SerialComm.Disconnect();
                lb_conn_state.Text = "Disconnected";
                lb_conn_state.ForeColor = Color.Red;

                #region Button_disable
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
                bt_arm_grasp.Enabled = false;
                bt_arm_up.Enabled = false;
                bt_arm_down.Enabled = false;
                bt_stop.Enabled = true;
                bt_homing.Enabled = true;
                tbar_servo1.Enabled = false;
                tbar_servo2.Enabled = false;
                tbar_servo3.Enabled = false;
                tbar_servo4.Enabled = false;
                #endregion
                this.KeyPreview = false;
            }
        }

        #endregion

        #region Motor control

        private void tbar_motA_Scroll(object sender, EventArgs e)
        {
            car.Motor_A.PWM = tbar_motA.Value;
            lb_motA_PWM.Text = Convert.ToString(tbar_motA.Value);

            if (mt_sync)
            {
                car.Motor_B.PWM = tbar_motA.Value;
                lb_motB_PWM.Text = Convert.ToString(tbar_motA.Value);
            }
        }

        private void tbar_motB_Scroll(object sender, EventArgs e)
        {
            car.Motor_B.PWM = tbar_motB.Value;
            lb_motB_PWM.Text = Convert.ToString(tbar_motB.Value);
            if (mt_sync)
            {
                car.Motor_A.PWM = tbar_motB.Value;
                lb_motA_PWM.Text = Convert.ToString(tbar_motB.Value);
            }
        }

        #endregion

        #region Button Click

        private void bt_stop_Click(object sender, EventArgs e)
        {
            car.Stop();
        }

        private void bt_forward_MouseDown(object sender, MouseEventArgs e)
        {
            bt_forward.ForeColor = Color.Yellow;
            car.Forward();
        }

        private void bt_forward_MouseUp(object sender, MouseEventArgs e)
        {
            bt_forward.ForeColor = SystemColors.ControlText;
            car.Soft_STOP();
        }

        private void bt_back_MouseDown(object sender, MouseEventArgs e)
        {
            bt_back.ForeColor = Color.Yellow;
            car.Backward();
        }

        private void bt_back_MouseUp(object sender, MouseEventArgs e)
        {
            bt_back.ForeColor = SystemColors.ControlText;
            car.Soft_STOP();
        }

        private void bt_left_MouseDown(object sender, MouseEventArgs e)
        {
            bt_left.ForeColor = Color.Yellow;
            car.TurnLeft();
        }

        private void bt_left_MouseUp(object sender, MouseEventArgs e)
        {
            bt_left.ForeColor = SystemColors.ControlText;
            car.Soft_STOP();
        }

        private void bt_right_MouseDown(object sender, MouseEventArgs e)
        {
            bt_right.ForeColor = Color.Yellow;
            car.TurnRight();
        }

        private void bt_right_MouseUp(object sender, MouseEventArgs e)
        {
            bt_right.ForeColor = SystemColors.ControlText;
            car.Soft_STOP();
        }

        private void bt_homing_Click(object sender, EventArgs e)
        {
            arm.Home();
            lb_sv1_deg.Text = Convert.ToString(arm.base_.home_deg);
            lb_sv2_deg.Text = Convert.ToString(arm.shoulder.home_deg);
            lb_sv3_deg.Text = Convert.ToString(arm.elbow.home_deg);
            lb_sv4_deg.Text = Convert.ToString(arm.gripper.home_deg);
            tbar_servo1.Value = arm.base_.home_deg;
            tbar_servo2.Value = arm.shoulder.home_deg;
            tbar_servo3.Value = arm.elbow.home_deg;
            tbar_servo4.Value = arm.gripper.home_deg;
        }

        private void bt_arm_left_MouseDown(object sender, MouseEventArgs e)
        {
            arm.base_.Degree--;
        }

        private void bt_arm_right_MouseDown(object sender, MouseEventArgs e)
        {
            arm.base_.Degree++;
        }

        private void bt_arm_fw_MouseDown(object sender, MouseEventArgs e)
        {
            arm.shoulder.Degree++;
        }

        private void bt_arm_back_MouseDown(object sender, MouseEventArgs e)
        {
            arm.shoulder.Degree--;
        }

        private void bt_arm_up_Click(object sender, EventArgs e)
        {
            arm.elbow.Degree++;
        }

        private void bt_arm_down_Click(object sender, EventArgs e)
        {
            arm.elbow.Degree--;
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
                bt_arm_left_MouseDown(null,null);
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

        #endregion

        #region Servo Bar pull

        private void tbar_servo1_Scroll(object sender, EventArgs e) //Base
        {
            arm.base_.Degree = tbar_servo1.Value;
            lb_sv1_deg.Text = Convert.ToString(tbar_servo1.Value);
        }

        private void tbar_servo2_Scroll(object sender, EventArgs e) //Shoulder
        {
            arm.shoulder.Degree = tbar_servo2.Value;
            lb_sv2_deg.Text = Convert.ToString(tbar_servo2.Value);
        }

        private void tbar_servo3_Scroll(object sender, EventArgs e) //Elbow
        {
            arm.elbow.Degree = tbar_servo3.Value;
            lb_sv3_deg.Text = Convert.ToString(tbar_servo3.Value);
        }

        private void tbar_servo4_Scroll(object sender, EventArgs e) //Gripper
        {
            arm.gripper.Degree = tbar_servo4.Value;
            lb_sv4_deg.Text = Convert.ToString(tbar_servo4.Value);
        }

        #endregion

        private void cb_mt_sync_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_mt_sync.Checked) mt_sync = true;
            else mt_sync = false;
        }

    }

}
