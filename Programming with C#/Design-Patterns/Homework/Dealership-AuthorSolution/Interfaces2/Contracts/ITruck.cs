namespace Interfaces.Contracts
{
    public interface ITruck : IVehicle
    {
        int WeightCapacity { get; }
    }
}
