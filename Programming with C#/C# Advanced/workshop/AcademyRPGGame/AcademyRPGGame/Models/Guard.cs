namespace AcademyRPG
{
    using AcademyRPG.Interfaces;
    using System.Collections.Generic;

    public class Guard : Fighter, IFighter
    {
        public Guard(string name, Point position, int owner)
            : base(name, position, owner)
        {
            this.AttackPoints = 50;
            this.DefensePoints = 20;
            this.HitPoints = 100;
        }

    }
}
