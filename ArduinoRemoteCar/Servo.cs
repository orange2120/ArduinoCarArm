using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArduinoRemoteCar
{
    class Servo
    {
        private static int servo_deg = 0;
        private static int servo_home = 100; //Home position
        public static string CMD = "e";
        
        enum types {Base, Shoulder, Elbow, Gripper};

        private static int current_type = 0;

        public static void Set_type(int index)
        {
            current_type = index;
        }

        public static int Get_degree()
        {
            return servo_deg;
        }

        public static void Set_degree(int deg)
        {
            servo_deg = deg;
            this.Update_degree();
        }

        public void home()
        {
            servo_deg = servo_home;
            this.Update_degree();
        }

        private void Update_degree()
        {
            SerialComm.Send_cmd(this.CMD + Convert.ToString(servo_deg));
        }
    }
}
