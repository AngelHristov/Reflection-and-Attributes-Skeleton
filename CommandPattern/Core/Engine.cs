using CommandPattern.Core.Contracts;

namespace CommandPattern
{
    internal class Engine : IEngine
    {
        private readonly ICommandInterpreter commandInterpreter;

        public Engine(ICommandInterpreter command)
        {
            this.commandInterpreter = command;
        }

        public void Run()
        {
            System.Console.ReadLine();
        }
    }
}