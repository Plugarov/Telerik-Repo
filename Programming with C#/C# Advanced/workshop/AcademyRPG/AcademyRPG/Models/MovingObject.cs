namespace AcademyRPG.Models
{
    using System;
    using AcademyRPG.Interfaces;

    public abstract class MovingObject : WorldObject, IWorldObject, IMovingObject
    {
        public MovingObject(int owner, Point position) 
            : base(owner, position)
        {
        }

        public void GoTo(Point point)
        {
            this.position = point;
        }
    }
}
