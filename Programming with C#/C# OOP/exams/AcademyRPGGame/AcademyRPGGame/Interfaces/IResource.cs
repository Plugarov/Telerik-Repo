namespace AcademyRPG.Interfaces
{
    public interface IResource : IWorldObject
    {
        int Quantity
        {
            get;
        }

        ResourceType Type
        {
            get;
        }
    }
}
