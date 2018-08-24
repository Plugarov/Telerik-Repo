namespace AcademyRPG
{
    using AcademyRPG.Interfaces;
    public abstract class StaticObject : WorldObject
    {
        public StaticObject(Point position, int owner = 0)
            : base(position, owner)
        {
        }
    }
}
