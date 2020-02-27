using System;
using System.Windows.Forms;

namespace Server
{
    static class Console
    {
        public static Serial serial;

        public static TextBox TextConsole { get; set; }
        public static TextBox TextInput { get; set; }

        static CommandExecutor executor = new CommandExecutor();

        public static void Run()
        {
            executor.Register("read", new ReadCommandProc());
            executor.Register("clear", new ClearCommandProc());
            executor.Register("send", new SendCommandProc());
        }

        public static void Read()
        {
            string str = TextInput.Text;
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
                executor.RunCommand(command);
            }
            catch
            {
                WriteLine("Command not found");
            }
        }

        public static void Write(string message)
        {
            TextConsole.AppendText(message);
        }

        public static void WriteLine(string message)
        {
            TextConsole.AppendText(message + Environment.NewLine);
        }

        public static void Send(string port)
        {
            
        }

        public static void Clear()
        {
            TextConsole.Clear();
        }
    }
}
