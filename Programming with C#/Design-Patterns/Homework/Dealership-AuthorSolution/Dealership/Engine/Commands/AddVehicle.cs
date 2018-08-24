using System;

using Dealership.Factories;
using Interfaces.Contracts;
using Interfaces.Engine;
using Interfaces.Enums;

namespace Dealership.Engine.Commands
{
    public class AddVehicle : CommandHandler
    {
        private const string VehicleAddedSuccessfully = "{0} added vehicle successfully!";

        private IUserProvider userProvider;
        private IDealershipFactory factory;

        public AddVehicle(IUserProvider userProvider, IDealershipFactory factory)
            : base()
        {
            this.userProvider = userProvider;
            this.factory = factory;
        }

        public override bool CanHandle(IRequestParser command)
        {
            return command.Name.Equals("AddVehicle");
        }

        public override string ProcessCommandInternal(IRequestParser command)
        {

            var type = command.Parameters[0];
            var make = command.Parameters[1];
            var model = command.Parameters[2];
            var price = decimal.Parse(command.Parameters[3]);
            var additionalParam = command.Parameters[4];

            var typeEnum = (VehicleType)Enum.Parse(typeof(VehicleType), type, true);

            return this.ProcessAddVehicle(typeEnum, make, model, price, additionalParam);
        }

        public string ProcessAddVehicle(VehicleType type, string make, string model, decimal price, string additionalParam)
        {
            IVehicle vehicle = null;

            if (type == VehicleType.Car)
            {
                vehicle = this.factory.CreateCar(make, model, price, int.Parse(additionalParam));
            }
            else if (type == VehicleType.Motorcycle)
            {
                vehicle = this.factory.CreateMotorcycle(make, model, price, additionalParam);
            }
            else if (type == VehicleType.Truck)
            {
                vehicle = this.factory.CreateTruck(make, model, price, int.Parse(additionalParam));
            }

            this.userProvider.LoggedUser.AddVehicle(vehicle);

            return string.Format(VehicleAddedSuccessfully, this.userProvider.LoggedUser.Username);
        }
    }
}
