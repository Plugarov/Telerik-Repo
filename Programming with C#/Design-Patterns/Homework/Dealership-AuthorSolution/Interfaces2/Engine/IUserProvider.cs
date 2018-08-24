using Interfaces.Contracts;
using System.Collections.Generic;

namespace Interfaces.Engine
{
    public interface IUserProvider
    {
        IUser LoggedUser { get; set; }

        IList<IUser> Users { get; set; }

        void Add(IUser user);
    }
}
