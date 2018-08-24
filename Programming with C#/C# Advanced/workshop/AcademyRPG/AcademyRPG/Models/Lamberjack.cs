namespace AcademyRPG.Models
{
    using System;

    using AcademyRPG.Interfaces;

    public class Lamberjack : Character, IGatherer
    {
        public Lamberjack(int owner, Point position, string name)
            : base(owner, position)
        {
            this.hitPoints = 50;
            this.name = name;
        }

        public bool TryGather(IResource resource)
        {
            bool checkIfGatherSucess = false;
            if (resource.Quantity > 0)
            {
                checkIfGatherSucess = true;
            }

            return checkIfGatherSucess;
        }
    }
}
