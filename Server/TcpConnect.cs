using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
	class TcpConnect
	{
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

		public async Task Run()
		{
			tcpListener = TcpListener.Create(port);
			tcpListener.Start();
			Console.WriteLine("Server is started.");

			await Task.Run(async () =>
			{
				while (true)
				{
					TcpClient tcpClient = await tcpListener.AcceptTcpClientAsync();
					NewTcpConnectAsync(tcpClient);
				}
					
			});
		}

		void NewTcpConnectAsync(TcpClient client)
		{
			Task taskClient = new Task(async () =>
			{
				while (true)
				{
					try
					{
						Console.WriteLine("Client is connect.");

						await processClient(client);
					}
					catch
					{
						Console.WriteLine("Client is disconnect.");
						break;
					}
				}
			});
			taskClient.Start();
		}

		async Task processClient(TcpClient client)
		{
			var clientTCP = new Client(client);
			await clientTCP.ProcessAsync();
		}
	}
}
