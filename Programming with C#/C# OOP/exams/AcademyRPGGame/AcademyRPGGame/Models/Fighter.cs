namespace AcademyRPG
{
    using AcademyRPG.Interfaces;
    using System.Collections.Generic;

    public abstract class Fighter : Character, IFighter
    {
        private int attackPoints;
        private int defensePoints;

        public Fighter(string name, Point position, int owner)
            : base(name, position, owner)
        {
        }

        public int AttackPoints
        {
            get { return this.attackPoints; }
            protected set { this.attackPoints = value; }
        }

        public int DefensePoints
        {
            get { return this.defensePoints; }
            protected set { this.defensePoints = value; }
        }

        public virtual int GetTargetIndex(List<WorldObject> availableTargets)
        {
            for (int i = 0; i < availableTargets.Count; i++)
            {
                if (availableTargets[i].Owner != this.Owner && availableTargets[i].Owner != 0)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
