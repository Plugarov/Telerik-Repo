namespace AcademyRPG
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using AcademyRPG.Interfaces;

    internal class Ninja : Fighter, IFighter, IGatherer
    {
        public Ninja(string name, Point position, int owner)
            : base(name, position, owner)
        {
            this.HitPoints = 1;
            this.AttackPoints = 0;
            this.DefensePoints = int.MaxValue;
        }

        public override int GetTargetIndex(List<WorldObject> availableTargets)
        {
            WorldObject result = availableTargets
                .OrderByDescending(x => x.HitPoints)
                .FirstOrDefault(x => x.Owner != 0 && x.Owner != this.Owner);

            return availableTargets.IndexOf(result);
        }

        public bool TryGather(IResource resource)
        {
            bool gathered = false;

            if (resource.Type == ResourceType.Stone)
            {
                this.AttackPoints += resource.Quantity;
                gathered = true;
            }

            if (resource.Type == ResourceType.Lumber)
            {
                this.AttackPoints += (resource.Quantity * 2);
                gathered = true;
            }
            return gathered;
        }
    }
}