namespace AcademyRPG
{
    using System;
    using AcademyRPG.Interfaces;

    public class Rock : StaticObject, IResource
    {
        public Rock(Point position, int size, int owner = 0)
            : base(position, owner)
        {
            this.HitPoints = size;
        }

        public ResourceType Type
        {
            get
            {
                return ResourceType.Stone;
            }
        }

        public int Quantity
        {
            get
            {
                return this.HitPoints / 2;
            }
        }
    }
}
