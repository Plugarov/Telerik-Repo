﻿using Interfaces.Enums;

namespace Interfaces.Contracts
{
    public interface IVehicle : ICommentable, IPriceable
    {
        int Wheels { get; }

        VehicleType Type { get; }

        string Make { get; }

        string Model { get;  }
    }
}
