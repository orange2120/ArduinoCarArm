﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.IO;

namespace ArduinoRemoteCar
{
    public class SerialComm
    {
        static SerialPort serialPort1;
         public delegate void AddDataDelegate();

        public class Connection_info
        {
            public static string[] GetPorts = SerialPort.GetPortNames();
            public static int[] BaudRate = new[] { 115200, 9600, 19200, 38400, 57600, 230400, 250000 };

        }

        public static string port { get; set; }
        public static int baud { get; set; }

        //TODO:
        /*private void AddData() //Receive data from serial port
        {
            string dataLine = serialPort1.ReadLine();
        }

        private static void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            Form1.Invoke(new AddDataDelegate(AddData));
        }*/

        public class SerialData : EventArgs
        {
            public string dataLine = serialPort1.ReadLine();
        }

        public static bool Connected()
        {
            if (serialPort1.IsOpen) return true;
            else return false;
        }

        public static bool Connect()
        {
            serialPort1 = new SerialPort(port, baud);
            //serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            if (!serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Open();
                }
                catch (Exception ex)
                {
                    // return ex;
                    return false;
                }
                return true;
            }
            return false;
        }

        public static bool Disconnect()
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                return true;
            }
            else return false;
            
        }

        public static void Send_cmd(string cmd)
        {
            if (!serialPort1.IsOpen) return;
            serialPort1.Write(cmd + "\n");
        }

        public static void Send_cmd_nr(string cmd)
        {
            if (!serialPort1.IsOpen) return;
            serialPort1.Write(cmd);
        }

    }
}
