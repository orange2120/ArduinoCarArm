using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArduinoRemoteCar
{
    class Car
    {

        //private int speed = 0;

        public Motor Motor_A = new Motor()
        {
            SPD_CMD = Command.MOT_A_SPD
        };
        public Motor Motor_B = new Motor()
        {
            SPD_CMD = Command.MOT_B_SPD
        };

        public void Stop()
        {
            SerialComm.Send_cmd(Command.STOP_CMD);
        }

        public void Soft_STOP()
        {
            SerialComm.Send_cmd(Command.SOFT_STOP_CMD);
        }

        public void TurnLeft()
        {
            SerialComm.Send_cmd(Command.LEFT_CMD);
        }

        public void TurnRight()
        {
            SerialComm.Send_cmd(Command.RIGHT_CMD);
        }

        public void Forward()
        {
            SerialComm.Send_cmd(Command.FORWARD_CMD);
        }

        public void Backward()
        {
            SerialComm.Send_cmd(Command.BACK_CMD);
        }
    }
}
