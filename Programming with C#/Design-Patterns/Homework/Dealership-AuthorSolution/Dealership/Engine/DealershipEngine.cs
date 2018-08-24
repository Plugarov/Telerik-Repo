using Dealership.Factories;
using InputOutputProviderInterface;
using Interfaces.Commands;
using Interfaces.Engine;

using System;
using System.Collections.Generic;
using System.Text;

namespace Dealership.Engine
{
    public sealed class DealershipEngine : IEngine
    {
        private ICommand startCommand;
        private IDealershipFactory dealershipFactory;
        private IInputOutputProvider inputOutputProvider;

        public DealershipEngine(
            ICommand startCommand, 
            IDealershipFactory dealershipFactory,
            IInputOutputProvider inputOutputProvider)
        {
            this.startCommand = startCommand;
            this.dealershipFactory = dealershipFactory;
            this.inputOutputProvider = inputOutputProvider;
        }

        public void Start()
        {
            var commands = this.ReadCommands();
            var commandResult = this.ProcessCommands(commands);
            this.PrintReports(commandResult);
        }

        private IList<IRequestParser> ReadCommands()
        {
            var commands = new List<IRequestParser>();

            var currentLine = inputOutputProvider.Read();

            while (!string.IsNullOrEmpty(currentLine))
            {
                IRequestParser currentCommand = this.dealershipFactory.CreateRequestParser(currentLine);
                commands.Add(currentCommand);
                currentLine = inputOutputProvider.Read();
            }

            return commands;
        }

        private IList<string> ProcessCommands(IList<IRequestParser> commands)
        {
            var reports = new List<string>();

            foreach (var command in commands)
            {
                try
                {
                    var report = this.startCommand.ProcessCommand(command);
                    reports.Add(report);
                }
                catch (Exception ex)
                {
                    reports.Add(ex.Message);
                }
            }

            return reports;
        }

        private void PrintReports(IList<string> reports)
        {
            var output = new StringBuilder();

            foreach (var report in reports)
            {
                output.AppendLine(report);
                output.AppendLine(new string('#', 20));
            }

            inputOutputProvider.Write(output.ToString());
        }
    }
}
