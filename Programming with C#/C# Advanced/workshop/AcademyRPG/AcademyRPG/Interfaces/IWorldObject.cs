namespace AcademyRPG.Interfaces
{
    using AcademyRPG.Models;

    public interface IWorldObject
    {
        int HitPoints
        {
            get;
        }
        Point Position
        {
            get;
        }
        bool IsDestroyed
        {
            get;
        }
    }
}
