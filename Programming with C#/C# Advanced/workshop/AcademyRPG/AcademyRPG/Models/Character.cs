namespace AcademyRPG.Models
{
    using System;
    using AcademyRPG.Interfaces;

    public abstract class Character : MovingObject, IMovingObject, IControllable
    {
        public string name;

        public Character(int owner, Point position) 
            : base(owner, position)
        {
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }
    }
}
