using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArduinoRemoteCar
{
    class Car
    {
        public class Motor
        {
            //Motor PWM value (0~255)
           public static int A_PWM = 100;
           public static int B_PWM = 100;
        }

        public class Speed()
        {

        }

        private void Stop()
        {
            
            SerialComm.Send_cmd(STOP_CMD);
        }
    }
}
