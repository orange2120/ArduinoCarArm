using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArduinoRemoteCar
{
    class Servo : Arm
    {
        public static int servo = 0;
        public static int servo_home = 100; //Home position

        private state void Set_type()
        {

        }

        private static int Get_degree()
        {
            return servo;
        }

        private static void Set_degree(int deg)
        {
            servo = deg;
            SerialComm.Send_cmd(this.type);
            SerialComm.send_cmd(Command.)
        }
    }
}
