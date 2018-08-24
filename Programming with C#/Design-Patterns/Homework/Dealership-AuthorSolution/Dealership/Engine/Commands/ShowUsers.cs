using Interfaces.Engine;
using Interfaces.Enums;
using System.Text;

namespace Dealership.Engine.Commands
{
    public class ShowUsers : CommandHandler
    {
        private const string YouAreNotAnAdmin = "You are not an admin!";

        private IUserProvider userProvider;

        public ShowUsers(IUserProvider userProvider)
            : base()
        {
            this.userProvider = userProvider;
        }

        public override bool CanHandle(IRequestParser command)
        {
            return command.Name.Equals("ShowUsers");
        }

        public override string ProcessCommandInternal(IRequestParser command)
        {
            return this.ProcessShowAllUsers();
        }

        public string ProcessShowAllUsers()
        {
            if (this.userProvider.LoggedUser.Role != Role.Admin)
            {
                return YouAreNotAnAdmin;
            }

            var builder = new StringBuilder();
            builder.AppendLine("--USERS--");
            var counter = 1;
            foreach (var user in this.userProvider.Users)
            {
                builder.AppendLine(string.Format("{0}. {1}", counter, user.ToString()));
                counter++;
            }

            return builder.ToString().Trim();
        }
    }
}
