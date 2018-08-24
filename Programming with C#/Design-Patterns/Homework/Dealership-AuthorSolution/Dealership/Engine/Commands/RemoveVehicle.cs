using Interfaces.Engine;
using System;

namespace Dealership.Engine.Commands
{
    public class RemoveVehicle : CommandHandler
    {
        private const string RemovedVehicleDoesNotExist = "Cannot remove comment! The vehicle does not exist!";
        private const string VehicleRemovedSuccessfully = "{0} removed vehicle successfully!";

        private IUserProvider userProvider;

        public RemoveVehicle(IUserProvider userProvider) 
            : base()
        {
            this.userProvider = userProvider;
        }

        public override bool CanHandle(IRequestParser command)
        {
           return command.Name.Equals("RemoveVehicle");
        }

        public override string ProcessCommandInternal(IRequestParser command)
        {
            var vehicleIndex = int.Parse(command.Parameters[0]) - 1;

            return this.ProcessRemoveVehicle(vehicleIndex);
        }

        public string ProcessRemoveVehicle(int vehicleIndex)
        {
            ValidateRange(vehicleIndex, 0, this.userProvider.LoggedUser.Vehicles.Count, RemovedVehicleDoesNotExist);

            var vehicle = this.userProvider.LoggedUser.Vehicles[vehicleIndex];

            this.userProvider.LoggedUser.RemoveVehicle(vehicle);

            return string.Format(VehicleRemovedSuccessfully, this.userProvider.LoggedUser.Username);
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
