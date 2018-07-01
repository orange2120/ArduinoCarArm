using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArduinoRemoteCar
{
    class Arm
    {

        private int close_deg = 30;
        private int open_deg = 120;

        public class Position //Arm position in polar coordinate & Cartesian coordinate
        {
            float r; //Radius
            float t; //degree

            float x;
            float y;
            float z;
        }

        Servo base_ = new Servo();
        Servo shoulder = new Servo();
        Servo elbow = new Servo();
        Servo gripper = new Servo();

        public void Home()
        {
            gripper.home();
            base_.home();
            shoulder.home();
            elbow.home();
        }


        public class gripper
        {

            public void Close()
            {
                this.Set_degree(close_deg);
            }
            public void Open()
            {
                this.Set_degree(open_deg);
            }
        }

    }
}