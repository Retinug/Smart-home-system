using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace Server
{
    class Serial
    {
        public SerialPort Port;
        
        public Serial(string portname)
        {
            Port = new SerialPort(portname);

            Port.DtrEnable = true;
            Port.RtsEnable = true;
        }

        public static string[] GetPorts()
        {
            return SerialPort.GetPortNames();
        }

        public void Connect()
        {
            Port.Open();
        }
        
        public void Disconnect()
        {
            Port.Close();
            GC.Collect();
        }

        public void Send(byte[] message)
        {
            Port.Write(message, 0, message.Length);
        }

        public byte[] Read()
        {
            byte[] data = new byte[Port.BytesToRead];
            Port.Read(data, 0, data.Length);
            return data;
        }
    }
}
