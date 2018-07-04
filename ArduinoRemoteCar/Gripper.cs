using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArduinoRemoteCar
{
    class Gripper : Servo
    {
        private int close_deg = 30;
        private int open_deg = 120;

        public Gripper()
        {
            this.CMD = Command.GRIPPER_CMD;
        }

        public void Close()
        {
            Set_degree(close_deg);
        }
            public void Open()
        {
            Set_degree(open_deg);
        }
    }
}
