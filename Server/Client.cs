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

        async Task<byte[]> ReadFromStreamAsync(int nbytes)
        {
            var buf = new byte[nbytes];
            var readpos = 0;
            while (readpos < nbytes)
                readpos += await stream.ReadAsync(buf, readpos, nbytes - readpos);
            return buf;
        }

        public async Task ProcessAsync()
        {
            while (stream != null)
            {
                byte[] actionBuffer = await ReadFromStreamAsync(5);
                Console.WriteLine($"Received data {Encoding.ASCII.GetString(actionBuffer)}");
            }
        }

        public async Task WriteAsync()
        {
            byte[] data = new byte[1];

            if (stream.DataAvailable)
            {
                await stream.WriteAsync(data, 0, data.Length);
                Console.WriteLine(data.ToString());
            }

            Console.WriteLine(data.ToString());
        }
    }
}