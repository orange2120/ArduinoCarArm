using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArduinoRemoteCar
{
    public class Motor : Car
    {
        //Motor PWM value (0~255)
        public int PWM 
        {
            get { return PWM; }
            set
            {
                Update_PWM();
            }
        
        }

            public string SPD_CMD  { get; set; }
            //private string SPD_CMD = "";

            /*public void Set_SPD_CMD(string cmd)
            {
                SPD_CMD = cmd;
            }*/

            /*public int Get_PWM()
            {
                return this.PWM;
            }

            public void Set_PWM(int val)
            {
                this.PWM = val;
                this.Update_PWM();
            }*/

            private void Update_PWM()
            {
                SerialComm.Send_cmd(this.SPD_CMD + Convert.ToString(PWM));
            }
    }
}
