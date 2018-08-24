using Interfaces.Commands;
using Interfaces.Engine;

namespace Dealership.Engine.Commands
{
    public abstract class CommandHandler : ICommand
    {
        private const string InvalidCommand = "Invalid command!";

        private ICommand successor;

        public CommandHandler()
        {
        }

        public void SetSuccessor(ICommand successor)
        {
            this.successor = successor;
        }

        public string ProcessCommand(IRequestParser command)
        {
            if (this.CanHandle(command))
            {
                return this.ProcessCommandInternal(command);
            }

            if (this.successor != null)
            {
                return this.successor.ProcessCommand(command);
            }

            return string.Format(InvalidCommand, command.Name);
        }

        public abstract bool CanHandle(IRequestParser command);

        public abstract string ProcessCommandInternal(IRequestParser command);
    }
}
