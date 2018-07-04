using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArduinoRemoteCar
{
    class Base_ : Servo
    {
        public Base_()
        {
            this.CMD = Command.BASE_CMD;
        }
    }
}
