using Interfaces.Engine;
using System.Linq;

namespace Dealership.Engine.Commands
{
    public class ShowVehicles : CommandHandler
    {
        private const string NoSuchUser = "There is no user with username {0}!";

        private IUserProvider userProvider;

        public ShowVehicles(IUserProvider userProvider) 
            : base()
        {
            this.userProvider = userProvider;
        }

        public override bool CanHandle(IRequestParser command)
        {
            return command.Name.Equals("ShowVehicles");
        }

        public override string ProcessCommandInternal(IRequestParser command)
        {
            var username = command.Parameters[0];

            return this.ShowUserVehicles(username);
        }

        public string ShowUserVehicles(string username)
        {
            var user = this.userProvider.Users.FirstOrDefault(u => u.Username.ToLower() == username.ToLower());

            if (user == null)
            {
                return string.Format(NoSuchUser, username);
            }

            return user.PrintVehicles();
        }
    }
}
