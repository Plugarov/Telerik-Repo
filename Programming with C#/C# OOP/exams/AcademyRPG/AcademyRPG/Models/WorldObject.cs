namespace AcademyRPG.Models
{
    using AcademyRPG.Interfaces;

    public abstract class WorldObject : IWorldObject
    {
        private int owner;
        protected int hitPoints;
        protected Point position;

        public WorldObject(int owner, Point position)
        {
            this.owner = owner;
            this.hitPoints = 0;
            this.position = position;
        }

        public int HitPoints
        {
            get
            {
                return this.hitPoints;
            }
        }

        public Point Position
        {
            get
            {
                return this.position;
            }
        }

        public bool IsDestroyed
        {
            get
            {
                return this.hitPoints <= 0;
            }
        }
    }
}
