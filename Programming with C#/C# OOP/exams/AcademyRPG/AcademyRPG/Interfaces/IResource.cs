namespace AcademyRPG.Interfaces
{
    using AcademyRPG.Models;

    public interface IResource 
    {
        int Quantity
        {
            get;
        }

        Type Type
        {
            get;
        }
    }
}
