using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
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

        //async Task<byte[]> ReadFromStreamAsync()
        //{
        //    return 
        //}

        public async Task ProcessAsync()
        {
            while (true)
            {
                byte[] actionBuffer = await ReadFromStreamAsync(5);

                Console.WriteLine(Encoding.ASCII.GetString(actionBuffer));
            }
            
            //var action = (Action)BitConverter.ToInt16(actionBuffer, 0);

            //switch (action)
            //{
            //    // логика в зависимости от кода команды
            //}
        }
    }
}