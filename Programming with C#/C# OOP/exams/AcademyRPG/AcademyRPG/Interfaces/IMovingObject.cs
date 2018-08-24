namespace AcademyRPG.Interfaces
{
    using AcademyRPG.Models;

    public interface IMovingObject
    {
        void GoTo(Point point);
    }
}
