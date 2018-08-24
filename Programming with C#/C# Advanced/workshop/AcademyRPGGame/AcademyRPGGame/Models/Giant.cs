namespace AcademyRPG
{
    using System;
    using System.Collections.Generic;
    using AcademyRPG.Interfaces;
    using System.Linq;

    public class Giant : Fighter, IFighter, IGatherer
    {
        private bool hasStone = false;

        public Giant(string name, Point position, int owner = 0)
            :base(name,position,owner)
        {
            this.AttackPoints = 150;
            this.DefensePoints = 80;
            this.HitPoints = 200;
        }

        public bool TryGather(IResource resource)
        {
            bool gathered = false;
            
            if(resource.Type == ResourceType.Stone)
            {
                if(!hasStone)
                {
                    this.AttackPoints += 100;
                    hasStone = true;
                }
                gathered = true;
            }
            return gathered;
        }

        public override int GetTargetIndex(List<WorldObject> availableTargets)
        {
            WorldObject result = availableTargets
                .FirstOrDefault(x => x.Owner != 0);

            return availableTargets.IndexOf(result);
        }
    }
}
