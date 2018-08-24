namespace AcademyRPG.Interfaces
{
    public interface IGatherer : IControllable
    {
        bool TryGather(IResource resource);
    }
}
