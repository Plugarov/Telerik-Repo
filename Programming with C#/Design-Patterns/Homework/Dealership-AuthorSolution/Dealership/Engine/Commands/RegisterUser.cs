using System;
using System.Linq;

using Dealership.Factories;
using Interfaces.Engine;
using Interfaces.Enums;

namespace Dealership.Engine.Commands
{
    public class RegisterUser : CommandHandler
    {
        private const string UserRegisterеd = "User {0} registered successfully!";
        private const string UserLoggedInAlready = "User {0} is logged in! Please log out first!";
        private const string UserAlreadyExist = "User {0} already exist. Choose a different username!";

        private IUserProvider userProvider;
        private IDealershipFactory factory;

        public RegisterUser(IUserProvider userProvider, IDealershipFactory factory)
            : base()
        {
            this.userProvider = userProvider;
            this.factory = factory;
        }

        public override bool CanHandle(IRequestParser command)
        {
            return command.Name.Equals("RegisterUser");
        }

        public override string ProcessCommandInternal(IRequestParser command)
        {
            var username = command.Parameters[0];
            var firstName = command.Parameters[1];
            var lastName = command.Parameters[2];
            var password = command.Parameters[3];

            var role = Role.Normal;

            if (command.Parameters.Count > 4)
            {
                role = (Role)Enum.Parse(typeof(Role), command.Parameters[4]);
            }

            return this.ProcessRegisterUser(username, firstName, lastName, password, role);
        }

        private string ProcessRegisterUser(string username, string firstName, string lastName, string password, Role role)
        {
            if (this.userProvider.LoggedUser != null)
            {
                return string.Format(UserLoggedInAlready, this.userProvider.LoggedUser.Username);
            }

            if (this.userProvider.Users.Any(u => u.Username.ToLower() == username.ToLower()))
            {
                return string.Format(UserAlreadyExist, username);
            }

            var user = this.factory.CreateUser(username, firstName, lastName, password, role);
            this.userProvider.LoggedUser = user;
            this.userProvider.Add(user);

            return string.Format(UserRegisterеd, username);
        }
    }
}
