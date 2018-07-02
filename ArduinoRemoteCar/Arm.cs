using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArduinoRemoteCar
{
    class Arm
    {

        public Gripper gripper = new Gripper();
        public Elbow elbow = new Elbow();
        public Base_ base_ = new Base_();
        public Shoulder shoulder = new Shoulder();

        public class Position //Arm position in polar coordinate & Cartesian coordinate
        {
            float r; //Radius
            float t; //degree

            float x;
            float y;
            float z;
        }

        public void Home()
        {
            gripper.home();
            base_.home();
            shoulder.home();
            elbow.home();
        }

    }
}