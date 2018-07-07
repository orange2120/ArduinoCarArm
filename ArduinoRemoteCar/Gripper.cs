using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArduinoRemoteCar
{
    public class Gripper : Servo
    {
        private int close_deg = 30;
        private int open_deg = 120;

        public Gripper()
        {
            this.CMD = Command.GRIPPER_CMD;
        }

        public void Close()
        {
            this.Degree = close_deg;
        }
        public void Open()
        {
            this.Degree = open_deg;
        }
    }
}
