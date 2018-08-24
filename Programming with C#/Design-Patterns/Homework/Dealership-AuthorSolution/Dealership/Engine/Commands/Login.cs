using Interfaces.Contracts;
using Interfaces.Engine;
using System.Collections.Generic;
using System.Linq;

namespace Dealership.Engine.Commands
{
    public class Login : CommandHandler
    {
        private const string UserLoggedIn = "User {0} successfully logged in!";
        private const string UserLoggedInAlready = "User {0} is logged in! Please log out first!";
        private const string WrongUsernameOrPassword = "Wrong username or password!";

        private IUserProvider userProvider;

        public Login(IUserProvider userProvider) 
            : base()
        {
            this.userProvider = userProvider;
        }

        public override bool CanHandle(IRequestParser command)
        {
            return command.Name.Equals("Login");
        }

        public override string ProcessCommandInternal(IRequestParser command)
        {
            var username = command.Parameters[0];
            var password = command.Parameters[1];

            return this.ProcessLogin(username, password);
        }

        private string ProcessLogin(string username, string password)
        {
            if (this.userProvider.LoggedUser != null)
            {
                return string.Format(UserLoggedInAlready, this.userProvider.LoggedUser.Username);
            }

            var userFound = this.userProvider.Users.FirstOrDefault(u => u.Username.ToLower() == username.ToLower());

            if (userFound != null && userFound.Password == password)
            {
                this.userProvider.LoggedUser = userFound;
                return string.Format(UserLoggedIn, username);
            }

            return WrongUsernameOrPassword;
        }
    }
}
