using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.IO;

namespace ArduinoRemoteCar
{
    class SerialComm
    {
        private static SerialPort serialPort1;


        serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

        public delegate void AddDataDelegate();

        public class Connection_info
        {
            public static string[] GetPorts = SerialPort.GetPortNames();
            public static int[] BaudRate = new[] { 115200, 9600, 19200, 38400, 57600, 230400, 250000 };

        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new AddDataDelegate(AddData));
        }

        private void AddData() //Receive data from serial port
        {
            string dataLine = serialPort1.ReadLine();
        }

        private static void set_COM_port(string port)
        {
             serialPort1.PortName = port;
        }

        private static void set_Baud_rate(int baud)
        {
            serialPort1.BaudRate = baud;
        }

        public static bool Connected()
        {
            return serialPort1.IsOpen();
        }

        private static void Connect()
        {
            if(!serialPort1.IsOpen())
            {
                try
                {
                    serialPort1.Open();
                }
                catch
                {

                }
            }

        }

        public static bool Disconnect()
        {

            return 
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
