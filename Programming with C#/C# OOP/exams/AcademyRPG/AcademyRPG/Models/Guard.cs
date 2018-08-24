namespace AcademyRPG.Models
{
    using System;
    using System.Collections.Generic;
    using AcademyRPG.Interfaces;

    public class Guard : Character, IControllable, IFighter
    {
        public Guard(int owner, Point position, string name)
            : base(owner, position)
        {
            this.hitPoints = 100;
            this.name = name;
        }

        public int AttackPoints
        {
            get;
            set;
        }

        public int DeffencePoints
        {
            get;
            set;
        }

        public int GetTargetIndex(List<WorldObject> list)
        {
            throw new NotImplementedException();
        }
    }
}
