using System;
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


        public class Connection_info
        {
            public static string[] GetPorts = SerialPort.GetPortNames();
            public static int[] BaudRate = new[] { 115200, 9600, 19200, 38400, 57600, 230400, 250000 };

        }

        public static string port { get; set; }
        public static int baud {get;set;}

        private void AddData() //Receive data from serial port
        {
            string dataLine = serialPort1.ReadLine();
        }

        /*public void set_COM_port(string port)
        {
             serialPort1.PortName = port;
        }*/

        /*public void set_Baud_rate(int baud)
        {
            serialPort1.BaudRate = baud;
        }*/

        public static bool Connected()
        {
            if (serialPort1.IsOpen) return true;
            else return false;
        }

        public static bool Connect()
        {
            if (!serialPort1.IsOpen)
            {
                try
                {
                    serialPort1 = new SerialPort(port,baud);
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
            }
            return true;
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
