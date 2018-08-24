using Interfaces.Engine;

namespace Dealership.Engine.Commands
{
    public class Logout : CommandHandler
    {
        private const string UserLoggedOut = "You logged out!";

        private IUserProvider userProvider;

        public Logout(IUserProvider userProvider)
            : base()
        {
            this.userProvider = userProvider;
        }

        public override bool CanHandle(IRequestParser command)
        {
            return command.Name.Equals("Logout");
        }

        public override string ProcessCommandInternal(IRequestParser command)
        {
            return this.ProcessLogout();
        }

        public string ProcessLogout()
        {
            this.userProvider.LoggedUser = null;
            return UserLoggedOut;
        }
    }
}
