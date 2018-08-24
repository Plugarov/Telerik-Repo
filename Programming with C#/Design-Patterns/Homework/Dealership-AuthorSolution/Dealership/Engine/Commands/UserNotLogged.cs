using Interfaces.Engine;

namespace Dealership.Engine.Commands
{
    public class UserNotLogged : CommandHandler
    {
        private const string UserNotLoggedConst = "You are not logged! Please login first!";

        private IUserProvider userProvider;

        public UserNotLogged(IUserProvider userProvider)
            : base()
        {
            this.userProvider = userProvider;
        }

        public override bool CanHandle(IRequestParser command)
        {
            return command.Name != "RegisterUser" && command.Name != "Login" && this.userProvider.LoggedUser == null;
        }

        public override string ProcessCommandInternal(IRequestParser command)
        {
            return UserNotLoggedConst;
        }
    }
}