using Interfaces.Contracts;
using Interfaces.Engine;
using System.Collections.Generic;

namespace Dealership.Engine
{
    public class UserProvider : IUserProvider
    {
        private IList<IUser> users;

        public UserProvider()
        {
            this.users = new List<IUser>();
        }

        public IUser LoggedUser { get; set; }

        public IList<IUser> Users
        {
            get
            {
                return this.users;
            }
            set
            {
                this.users = value;
            }
        }

        public void Add(IUser user)
        {
            this.users.Add(user);
        }
    }
}