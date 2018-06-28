using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArduinoRemoteCar
{
    class Servo : Arm
    {
        private static int servo = 0;
        private static int servo_home = 100; //Home position
        
        enum types {Base, Shoulder, Elbow, Gripper};

        int current_type = 0;

        private state void Set_type(int index)
        {
            current_type = index;
        }

        private static int Get_degree()
        {
            return servo;
        }

        private static void Set_degree(int deg)
        {
            servo = deg;
        }
    }
}
