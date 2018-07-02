using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArduinoRemoteCar
{
    public class Motor
    {
        //Motor PWM value (0~255)
            private static int PWM = 100;

            public string SPD_CMD
            {
                get;
                set;
            }
            //private string SPD_CMD = "";

            /*public void Set_SPD_CMD(string cmd)
            {
                SPD_CMD = cmd;
            }*/

            public int Get_PWM()
            {
                return PWM;
            }

            public void Set_PWM(int val)
            {
                PWM = val;
                this.Update_PWM();
            }

            private void Update_PWM()
            {
                SerialComm.Send_cmd(this.SPD_CMD + Convert.ToString(PWM));
            }
    }
}
