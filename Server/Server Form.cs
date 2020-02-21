using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace Server
{
    public partial class Server_Form : Form
    {
        Serial serial;

        public Server_Form()
        {
            InitializeComponent();
            RefreshPorts();

            Console.TextBox = text_Console;
        }

        #region Console
        private void text_Input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                try
                {
                    serial.Send(new byte[] { Convert.ToByte(text_Input.Text) });
                }
                catch
                {
                    Console.WriteLine("Command not found");
                }


                text_Input.Clear();
            }
        }

       
        #endregion

        #region Serial control
        private void list_Port_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_Port.SelectedIndex != -1 && serial == null)
            {
                button_Connect.Enabled = true;
            }
        }

        private void button_Connect_Click(object sender, EventArgs e)
        {
            serial = new Serial(list_Port.SelectedItem.ToString());

            serial.Port.DataReceived += port_DataReceived;

            serial.Connect();

            button_Connect.Enabled = false;
            button_Disconnect.Enabled = true;
        }

        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            byte[] data = serial.Read();

            Invoke((MethodInvoker)delegate {
                for (int i = 0; i < data.Length; i++)
                {
                    Console.WriteLine(data[i].ToString());
                }
            });
            
        }

        private void button_Disconnect_Click(object sender, EventArgs e)
        {
            serial.Disconnect();
            serial = null;

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
            if (ports.Length == 0)
            {
                MessageBox.Show("No available ports!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion
    }
}
