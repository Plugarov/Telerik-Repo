namespace AcademyRPG
{
    using AcademyRPG.Interfaces;
    using System.Collections.Generic;
    using System.Linq;

    public class Knight : Fighter, IFighter
    {
        public Knight(string name, Point position, int owner)
            : base(name, position, owner)
        {
            this.AttackPoints = 100;
            this.DefensePoints = 100;
            this.HitPoints = 100;
        }

        public override int GetTargetIndex(List<WorldObject> availableTargets)
        {
            WorldObject result = availableTargets
                .FirstOrDefault(x => x.Owner != 0 && x.Owner != this.Owner);

            return availableTargets.IndexOf(result);
        }
    }
}
