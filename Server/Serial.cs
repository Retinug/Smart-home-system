using System;
using System.IO.Ports;

namespace Server
{
	class Serial
	{
		public SerialPort Port;

		public bool isConnect
		{
			get
			{
				if (Port != null) return true;
				else return false;
			}
		}

		
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

		public void Send(byte message)
		{
			byte[] send = new byte[1];
			send[0] = message;
			Port.Write(send, 0, 1);
		}
		public void Send(byte[] message)
		{
			Port.Write(message, 0, message.Length);
		}

		public byte[] Read()
		{
			byte[] data = new byte[Port.BytesToRead];
			Port.Read(data, 0, data.Length);
			try
			{
				Console.tcpConnect.AcceptData.Invoke(data);
			}
			catch
			{}
			
			return data;
		}
	}
}
