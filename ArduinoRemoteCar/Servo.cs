using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArduinoRemoteCar
{
    public abstract class Servo// : Arm
    {
        private int servo_deg = 0;
        private int servo_home = 100; //Home position
        public string CMD { get; set; }

        public int Degree
        {
            get { return servo_deg; }
            set
            {
                if ((value <= 180) && (value >= 0))
                {
                    servo_deg = value;
                    Update_degree();
                }
            }
        }

        public int home_deg
        {
            get { return servo_home; }
            set { servo_home = value; }
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
