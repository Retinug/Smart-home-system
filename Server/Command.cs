using System;
using System.Collections.Generic;

namespace Server
{
   
    public interface ICommand
    {
        string Name { get; }
    }

    public interface ICommandProcessor
    {
        void RunCommand(ICommand command);

        void HelpCommand();
    }

    public class CommandExecutor : ICommandProcessor
    {
        public Dictionary<string, ICommandProcessor> commands = new Dictionary<string, ICommandProcessor>();

        public void Register(string namecommand, ICommandProcessor command)
        {
            commands.Add(namecommand, command);
        }

        public void RunCommand(ICommand command)
        {
            if (!commands.ContainsKey(command.Name)) throw new Exception("CommandException");
            commands[command.Name].RunCommand(command);
        }

        public void HelpCommand()
        {
            foreach (var item in commands)
            {
                item.Value.HelpCommand();
            }
        }
    }

    public class Command : ICommand
    {
        public string Name { get; protected set; }
        public Command(string name)
        {
            Name = name;
        }
    }

    public class CommandArg : Command
    {
        public string Arg { get; set; }
        public CommandArg(string name, string arg) : base(name)
        {
            Name = name;
            Arg = arg;
        }
    }
    #region Exception

    public class BoardNotConnectedException : Exception
    {
        public BoardNotConnectedException() : base() { }
    }

    public class ArgsNotSetException : Exception
    {
        public ArgsNotSetException() : base() { }
    }
    #endregion

    #region Commands

    public class ClearCommandProc : ICommandProcessor
    {
        public void RunCommand(ICommand command)
        {
            Console.Clear();
        }

        public void HelpCommand()
        {
            Console.WriteLine("clear - clear screen.");
        }
    }

    public class SendCommandProc : ICommandProcessor
    {
        public void RunCommand(ICommand command)
        {
            CommandArg commandArg = command as CommandArg;

            if (commandArg == null) throw new ArgsNotSetException();
            if (Console.serial == null) throw new BoardNotConnectedException();
            if (Console.serial.isConnect)
            {
                byte send = Convert.ToByte(commandArg.Arg);
                Console.serial.Send(send);
                Console.WriteLine($"Bytes sended: {send}");
            }
            else
            {
                throw new BoardNotConnectedException();
            }
            
        }

        public void HelpCommand()
        {
            Console.WriteLine("send [byte] - send byte to serial port.");
        }
    }

    public class ConnectCommandProc : ICommandProcessor
    {
        public void RunCommand(ICommand command)
        {
            CommandArg commandArg = command as CommandArg;
            if (commandArg == null || !commandArg.Arg.Contains("COM")) throw new ArgsNotSetException();
            if (commandArg == null) throw new ArgsNotSetException();

            Console.serial = new Serial(commandArg.Arg);
            
            Console.serial.Connect();
            Console.WriteLine($"Connected {commandArg.Arg}.");

            Console.Server_Form.button_Connect.Enabled = false;
            Console.Server_Form.button_Disconnect.Enabled = true;

            Console.Server_Form.list_Port.SelectedIndex = Console.Server_Form.list_Port.FindString(commandArg.Arg);
        }

        public void HelpCommand()
        {
            Console.WriteLine("connect [COM[port]] - board connection.");
        }
    }

    public class DisconnectCommandProc : ICommandProcessor
    {
        public void RunCommand(ICommand command)
        {
            if (Console.serial == null) throw new BoardNotConnectedException();
            Console.serial.Disconnect();
            Console.WriteLine($"Disconnected {Console.serial.Port.PortName}.");

            Console.Server_Form.button_Connect.Enabled = true;
            Console.Server_Form.button_Disconnect.Enabled = false;

            Console.Server_Form.list_Port.SelectedIndex = -1;
        }

        public void HelpCommand()
        {
            Console.WriteLine("disconnect - board disconnect.");
        }
    }

    public class RefreshCommandProc : ICommandProcessor
    {
        public void RunCommand(ICommand command)
        {
            Console.Server_Form.list_Port.Items.Clear();
            Console.Server_Form.list_Port.SelectedIndex = -1;
            Console.Server_Form.button_Connect.Enabled = false;

            string[] ports = Serial.GetPorts();
            foreach (var port in ports)
            {
                Console.Server_Form.list_Port.Items.Add(port);
            }
        }

        public void HelpCommand()
        {
            Console.WriteLine("refresh - refresh conenction list.");
        }
    }

    #endregion
}
