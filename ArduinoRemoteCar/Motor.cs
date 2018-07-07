using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArduinoRemoteCar
{
    class Motor //: Car
    {
        public string SPD_CMD { get; set; }
        //Motor PWM value (0~255)
        private int PWM_val = Command.DEFAULT_MOT_PWM;

        public Motor()
        {
            //Update_PWM();
        }

        public int PWM
        {
            get
            {
                return PWM_val;
            }
            set
            {
                PWM_val = value;
                Update_PWM();
            }
        }

        private void Update_PWM()
        {
            SerialComm.Send_cmd(this.SPD_CMD + Convert.ToString(PWM));
        }
    }
}
