using System.Collections.Generic;

using Interfaces.Contracts;
using Dealership.Factories;
using Interfaces.Engine;

namespace Dealership.Engine.Commands
{
    class ResetProgramParameters : CommandHandler
    {
        private IUserProvider userProvider;
        private IDealershipFactory factory;

        public ResetProgramParameters(
            IUserProvider userProvider,
            IDealershipFactory factory
            )
        {
            this.userProvider = userProvider;
            this.factory = factory;
        }

        public override bool CanHandle(IRequestParser command)
        {
            return command.Name.Equals("Reset");
        }

        public override string ProcessCommandInternal(IRequestParser command)
        {
            this.userProvider.LoggedUser = null;
            this.userProvider.Users = new List<IUser>();
            return "Reset compleate.";
        }
    }
}
