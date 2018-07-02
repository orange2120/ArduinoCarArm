using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArduinoRemoteCar
{
    public class Elbow : Servo
    {
        public Elbow()
        {
            this.CMD = Command.ELBOW_CMD;
        }
    }
}
