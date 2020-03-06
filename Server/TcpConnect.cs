using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
	class TcpConnect
	{
		public List<TcpClient> tcpClients = new List<TcpClient>();

		TcpListener tcpListener;

		ushort port;
		public TcpConnect(ushort port)
		{
			this.port = port;
		}

		public async Task RunAsync()
		{
			tcpListener = TcpListener.Create(port);
			tcpListener.Start();
			Console.WriteLine("Server is started.");
			while (true)
			{
				TcpClient tcpClient = await tcpListener.AcceptTcpClientAsync();

				tcpClients.Add(tcpClient);
				Console.WriteLine("Client is connect.");
				try
				{
					await processClient(tcpClient);
				}
				catch
				{
					Console.WriteLine("Client is disconnect.");
				}
			}
		}

		async Task processClient(TcpClient client)
		{
			var clientTCP = new Client(client);
			await clientTCP.ProcessAsync();
		}



	}
}
