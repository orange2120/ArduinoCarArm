using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArduinoRemoteCar
{
    class Shoulder : Servo
    {
        public Shoulder()
        {
            this.CMD = Command.SHOULDER_CMD;
        }
    }
}
