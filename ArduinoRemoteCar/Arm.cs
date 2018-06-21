using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArduinoRemoteCar
{
    class Arm
    {
        public class Servo //Servo motor properties
        {
            
        }
        public class Position //Arm position in polar coordinate & Cartesian coordinate
        {
            float r; //Radius
            float t; //degree

            float x;
            float y;
            float z;
        }

        Servo Base = new Servo();
        Servo Shoulder = new Servo();
        Servo Elbow = new Servo();
        Servo Gripper = new Servo();

        public void GetPositon()
        {

        }

        public void Home()
        {
            SerialComm.Send_cmd();
        }

        public void Close_gripper()
        {
            SerialComm.
        }

    }
}