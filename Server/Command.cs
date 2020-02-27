using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
   
    public interface ICommand
    {
        string Name { get; }
    }

    public interface ICommandProcessor
    {
        void RunCommand(ICommand command);
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
            if(!commands.ContainsKey(command.Name))
                throw new Exception("CommandException");
            commands[command.Name].RunCommand(command);
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

    public class ReadCommandProc : ICommandProcessor
    {
        public void RunCommand(ICommand command)
        {
            Console.WriteLine($"{command.Name} command processed");
        }
    }

    public class ClearCommandProc : ICommandProcessor
    {
        public void RunCommand(ICommand command)
        {
            Console.Clear();
        }
    }

    public class SendCommandProc : ICommandProcessor
    {
        public void RunCommand(ICommand command)
        {
            CommandArg commandArg = command as CommandArg;
            byte send = Convert.ToByte(commandArg.Arg);
            Console.serial.Send(send);
            Console.WriteLine($"Bytes sended: {send}");
        }
    }
}
