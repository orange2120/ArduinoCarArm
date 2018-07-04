using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArduinoRemoteCar
{
    class Motor : Car
    {
        //Motor PWM value (0~255)
            private int PWM = 100;

            public string SPD_CMD { get; set; }

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
