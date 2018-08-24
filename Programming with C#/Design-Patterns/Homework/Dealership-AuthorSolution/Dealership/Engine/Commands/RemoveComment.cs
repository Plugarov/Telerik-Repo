using Interfaces.Engine;
using System;
using System.Linq;

namespace Dealership.Engine.Commands
{
    public class RemoveComment : CommandHandler
    {
        private const string NoSuchUser = "There is no user with username {0}!";
        private const string RemovedVehicleDoesNotExist = "Cannot remove comment! The vehicle does not exist!";
        private const string RemovedCommentDoesNotExist = "Cannot remove comment! The comment does not exist!";
        private const string CommentRemovedSuccessfully = "{0} removed comment successfully!";
        
        private IUserProvider userProvider;

        public RemoveComment(IUserProvider userProvider)
            : base()
        {
            this.userProvider = userProvider;
        }

        public override bool CanHandle(IRequestParser command)
        {
            return command.Name.Equals("RemoveComment");
        }

        public override string ProcessCommandInternal(IRequestParser command)
        {
            var vehicleIndex = int.Parse(command.Parameters[0]) - 1;
            var commentIndex = int.Parse(command.Parameters[1]) - 1;
            var username = command.Parameters[2];

            return this.ProcessRemoveComment(vehicleIndex, commentIndex, username);
        }

        public string ProcessRemoveComment(int vehicleIndex, int commentIndex, string username)
        {
            var user = this.userProvider.Users.FirstOrDefault(u => u.Username == username);

            if (user == null)
            {
                return string.Format(NoSuchUser, username);
            }

            ValidateRange(vehicleIndex, 0, user.Vehicles.Count, RemovedVehicleDoesNotExist);
            ValidateRange(commentIndex, 0, user.Vehicles[vehicleIndex].Comments.Count, RemovedCommentDoesNotExist);

            var vehicle = user.Vehicles[vehicleIndex];
            var comment = user.Vehicles[vehicleIndex].Comments[commentIndex];

            this.userProvider.LoggedUser.RemoveComment(comment, vehicle);

            return string.Format(CommentRemovedSuccessfully, this.userProvider.LoggedUser.Username);
        }

        public static void ValidateRange(int? value, int min, int max, string message)
        {
            if (value < min || value >= max)
            {
                throw new ArgumentException(message);
            }
        }
    }
}
