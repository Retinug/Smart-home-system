using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
	class Client : IDisposable
	{
		NetworkStream stream;

		public Client(TcpClient client)
		{
			stream = client.GetStream();
		}

		public void Dispose()
		{
			stream.Dispose();
		}

		async Task ReadStreamAsync(int count)
		{
			byte[] data = new byte[count];
			await stream.ReadAsync(data, 0, data.Length);
			//Console.WriteLine($"Received data {Encoding.ASCII.GetString(data)}.");
			Console.serial.Send(data[0]);
		}

		public void WriteStream(byte[] data)
		{
			try
			{
				stream.Write(data, 0, data.Length);
			}
			catch { }
		}

		public async Task ProcessAsync()
		{

			while (stream != null)
			{	
				await ReadStreamAsync(1);
			}
		}
	}
}