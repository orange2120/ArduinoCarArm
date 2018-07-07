using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArduinoRemoteCar
{
    public class Arm
    {
        public Gripper gripper;
        public Elbow elbow;
        public Base_ base_;
        public Shoulder shoulder;

        public Arm()
        {
            gripper = new Gripper();
            elbow = new Elbow();
            base_ = new Base_();
            shoulder = new Shoulder();
        } 

        private class Position //Arm position in polar coordinate & Cartesian coordinate
        {
            public static float r; //Radius
            public static float theta; //degree

            public static float x;
            public static float y;
            public static float z;
        }

        public void Home()
        {
            gripper.home();
            base_.home();
            shoulder.home();
            elbow.home();
        }

        public void Set_pos(float x, float y, float z)
        {
            Position.x = x;
            Position.y = y;
            Position.z = z;
        }
        public void Set_pos(float r, float t)
        {
            Position.r = r;
            Position.theta = t;
        }
    }
}