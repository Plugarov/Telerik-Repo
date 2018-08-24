namespace AcademyRPG.Interfaces
{
    using System.Collections.Generic;
    using AcademyRPG.Models;

    public interface IFighter
    {
        int AttackPoints
        {
            get;
        }

        int DeffencePoints
        {
            get;
        }

        int GetTargetIndex(List<WorldObject> list);
    }

}
