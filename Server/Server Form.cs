using System;
using System.IO.Ports;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Server
{
    public partial class Server_Form : Form
    {
        public delegate void SafeCallDelegate(string text);
        public Server_Form()
        {
            InitializeComponent();

            GetIP();

            RefreshPorts();

            Console.Server_Form = this;

            Console.Run();
        }

        #region Console
        private void text_Input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Console.Read();

                text_Input.Clear();
            }
        }

        #endregion

        private void GetIP()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    labelIP.Text = $"IP:{ip.ToString()}";
                }
            }
        }

        #region Serial control
        private void list_Port_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_Port.SelectedIndex != -1 && Console.serial == null)
            {
                button_Connect.Enabled = true;
            }
        }

        public void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] data = Console.serial.Read();
            //Console.Write("Serial receive: ");
            //for (int i = 0; i < data.Length; i++)
            //{
            //    Console.Write($"{data[i].ToString()} ");
            //}
            //Console.WriteLine();
        }

        private void button_Connect_Click(object sender, EventArgs e)
        {
            Console.serial = new Serial(list_Port.SelectedItem.ToString());

            Console.WriteLine($"Connected {Console.serial.Port.PortName} port.");

            Console.serial.Port.DataReceived += port_DataReceived;

            Console.serial.Connect();

            button_Connect.Enabled = false;
            button_Disconnect.Enabled = true;
        }

        private void button_Disconnect_Click(object sender, EventArgs e)
        {
            Console.WriteLine($"Disconnected {Console.serial.Port.PortName} port.");

            Console.serial.Disconnect();
            Console.serial.Port.Dispose();
            Console.serial = null;

            button_Connect.Enabled = true;
            button_Disconnect.Enabled = false;
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            list_Port.Items.Clear();
            list_Port.SelectedIndex = -1;
            button_Connect.Enabled = false;
            RefreshPorts();
        }
        
        private void RefreshPorts()
        {
            string[] ports = Serial.GetPorts();
            foreach (var port in ports)
            {
                list_Port.Items.Add(port);
            }
        }

        #endregion
    }
}
