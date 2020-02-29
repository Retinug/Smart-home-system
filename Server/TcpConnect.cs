using System.Net;
using System.Net.Sockets;

namespace Server
{
    class TcpConnect
    {
        IPAddress address;
        int port;

        TcpListener tcpListener;
        TcpClient tcpClient;

        byte[] data;

        public TcpConnect(IPAddress address, int port)
        {
            this.address = address;
            this.port = port;
            tcpListener = new TcpListener(address, port);
            tcpListener.Start();
        }

        public void Connect()
        {
            tcpClient = tcpListener.AcceptTcpClient();
        }

        public void Disconnect()
        {
            tcpClient.Close();
            tcpListener.Stop();
        }

        public void Send(byte[] data)
        {
            NetworkStream stream = tcpClient.GetStream();
            stream.Write(data, 0, data.Length);
        }
    }
}
