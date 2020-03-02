using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace Server
{
    class TcpConnect
    {
        IPAddress address;
        int port;

        public async void RunServer()
        {
            var tcpListener = TcpListener.Create(8888);
            Console.WriteLine(tcpListener.ToString());
            tcpListener.Start();
            while (true)
            {
                var tcpClient = await tcpListener.AcceptTcpClientAsync();
                Console.WriteLine("Client is connect.");
                try
                {
                    await processClientTearOff(tcpClient);
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Client is disconnect.");
                }
                
                
            }
        }
        async Task processClientTearOff(TcpClient client)
        {
            //using (var client = new Client(client))
            //    await client.ProcessAsync();
            var clientTCP = new Client(client);
            await clientTCP.ProcessAsync();
        }
    }
}
