using Interfaces.Engine;

namespace Interfaces.Commands
{
    public interface ICommand
    {
        string ProcessCommand(IRequestParser command);
    }
}
