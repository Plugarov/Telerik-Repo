using Dealership.Factories;
using Interfaces.Contracts;
using Interfaces.Engine;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dealership.Engine.Commands
{
    public class AddComment : CommandHandler
    {
        private const string NoSuchUser = "There is no user with username {0}!";
        private const string VehicleDoesNotExist = "The vehicle does not exist!";
        private const string CommentAddedSuccessfully = "{0} added comment successfully!";

        private IUserProvider userProvider;
        private IDealershipFactory factory;

        public AddComment(IUserProvider userProvider, IDealershipFactory factory)
            : base()
        {
            this.userProvider = userProvider;
            this.factory = factory;
        }

        public override bool CanHandle(IRequestParser command)
        {
            return command.Name.Equals("AddComment");
        }

        public override string ProcessCommandInternal(IRequestParser command)
        {
            var content = command.Parameters[0];
            var author = command.Parameters[1];
            var vehicleIndex = int.Parse(command.Parameters[2]) - 1;

            return this.ProcessAddComment(content, vehicleIndex, author);
        }

        public string ProcessAddComment(string content, int vehicleIndex, string author)
        {
            var comment = this.factory.CreateComment(content);
            comment.Author = this.userProvider.LoggedUser.Username;
            var user = this.userProvider.Users.FirstOrDefault(u => u.Username == author);

            if (user == null)
            {
                return string.Format(NoSuchUser, author);
            }

            ValidateRange(vehicleIndex, 0, user.Vehicles.Count, VehicleDoesNotExist);

            var vehicle = user.Vehicles[vehicleIndex];

            this.userProvider.LoggedUser.AddComment(comment, vehicle);

            return string.Format(CommentAddedSuccessfully, this.userProvider.LoggedUser.Username);
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
