using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Server
{
    static class Console
    {
        public static Serial serial;

        public static Server_Form Server_Form { get; set; }

        public static TcpConnect tcpConnect = new TcpConnect(8888);

        static CommandExecutor executor = new CommandExecutor();

        public static void Run()
        {
            executor.Register("clear", new ClearCommandProc());
            executor.Register("send", new SendCommandProc());
            executor.Register("connect", new ConnectCommandProc());
            executor.Register("disconnect", new DisconnectCommandProc());
            executor.Register("refresh", new RefreshCommandProc());
            //executor.Register("tcpsend", new TCPCommandProc());

            WriteLine("Server is up and waiting for connection...");
            tcpConnect = new TcpConnect(8888);
            tcpConnect.Run();
        }

        public static void Read()
        {
            string str = Server_Form.text_Input.Text;
            str = System.Text.RegularExpressions.Regex.Replace(str, @"\s+", " ");
            str = str.Trim();

            string[] input = new string[2];
            int spaceIndex = str.Length - (str.Length - str.IndexOf(' '));
            if(spaceIndex == -1)
            {
                input[0] = str;
            }
            else
            {
                input[0] = str.Substring(0, spaceIndex);
                str = str.Remove(0, spaceIndex + 1);
                input[1] = str; //str.Substring(str.IndexOf(' '), str.Length - 1);
            }
            


            Command command;

            if (input.Length > 1)
            {
                command = new CommandArg(input[0], input[1]);
            }
            else
            {
                command = new Command(input[0]);
            }

            try
            {
                if (input[0] == "help") executor.HelpCommand();
                else executor.RunCommand(command);
            }
            catch (BoardNotConnectedException)
            {
                WriteLine("Board not connected.");
            }
            catch (ArgsNotSetException)
            {
                WriteLine("Arguments not set.");
            }
            catch (System.IO.IOException)
            {
                WriteLine("COM does not exist.");
            }
            catch
            {
                WriteLine("Command not found.");
            }
        }

        public static void Write(string message)
        {
            Server_Form.text_Console.AppendText(message);
        }

        public static void WriteLine(string message)
        {
            //Server_Form.text_Console.Invoke()
            if (Server_Form.text_Console.InvokeRequired)
            {
                var d = new Server_Form.SafeCallDelegate(WriteLine);
                Server_Form.Invoke(d, new object[] { message });
            }
            else
            {
                Server_Form.text_Console.AppendText(message + Environment.NewLine);
            }
            
        }

        public static void Clear()
        {
            Server_Form.text_Console.Clear();
        }
    }
}
