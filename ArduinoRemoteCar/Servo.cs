using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArduinoRemoteCar
{
    public abstract class Servo : Arm
    {
        private int servo_deg = 0;
        private int servo_home = 100; //Home position
        public string CMD { get; set; }

        public int Get_degree()
        {
            return servo_deg;
        }

        public void Set_degree(int deg)
        {
            this.servo_deg = deg;
            Update_degree();
        }

        public int Get_home()
        {
            return servo_home;
        }

        public void Set_home(int deg)
        {
            this.servo_home = deg;
        }

        public void home()
        {
            this.servo_deg = servo_home;
            Update_degree();
        }

        private void Update_degree()
        {
            SerialComm.Send_cmd(CMD + Convert.ToString(servo_deg));
        }
    }
}
