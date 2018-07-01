using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArduinoRemoteCar
{
    class Car : Command
    {

        private static int speed = 0;

        public class Motor
        {
            //Motor PWM value (0~255)
            private static int PWM = 100;

            private static SPD_CMD
            {
                set
                {
                }
            }

            public static int Get_PWM()
            {
                return PWM;
            }

            public static void Set_PWM(int val)
            {
                PWM = val;
                this.Update_PWM();
            }

            private void Update_PWM()
            {
                SerialComm.Send_cmd(this.SPD_CMD + Convert.ToString(PWM));
            }
        }

        Motor Motor_A = Motor();

        Motor Motor_B = Motor();

        public void Stop()
        {
            SerialComm.Send_cmd(STOP_CMD);
        }

        public void Soft_STOP()
        {
            SerialComm.Send_cmd(SOFT_STOP_CMD);
        }

        /*private void Soft_STOP()
        {
            SerialComm.Send_cmd("A0");
            SerialComm.Send_cmd("B0");
            lb_motA_PWM.Text = "0";
            lb_motB_PWM.Text = "0";
        }*/

        public void TurnLeft()
        {
        }

        public void TurnRight()
        {
            
        }

        public void Forward()
        {

        }

        public void Backward()
        {

        }
    }
}
