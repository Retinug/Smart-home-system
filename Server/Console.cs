using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Server
{
    static class Console
    {
        public static Serial serial;

        public static Server_Form Server_Form { get; set; }

        public static List<TcpConnect> tcpConnects = new List<TcpConnect>();
        public static TcpConnect tcpConnect = new TcpConnect();

        static CommandExecutor executor = new CommandExecutor();

        public static void Run()
        {
            executor.Register("clear", new ClearCommandProc());
            executor.Register("send", new SendCommandProc());
            executor.Register("connect", new ConnectCommandProc());
            executor.Register("disconnect", new DisconnectCommandProc());
            executor.Register("refresh", new RefreshCommandProc());

            WriteLine("Server is up and waiting for connection...");

            tcpConnect.RunServer();
        }

        public static void Read()
        {
            string str = Server_Form.text_Input.Text;
            str = System.Text.RegularExpressions.Regex.Replace(str, @"\s+", " ");
            str = str.Trim();

            string[] input = str.Split(' ');

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
            Server_Form.text_Console.AppendText(message + Environment.NewLine);
        }

        public static void Clear()
        {
            Server_Form.text_Console.Clear();
        }
    }
}
