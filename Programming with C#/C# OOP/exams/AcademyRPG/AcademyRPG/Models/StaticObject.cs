namespace AcademyRPG.Models
{
    using AcademyRPG.Interfaces;

    public abstract class StaticObject : WorldObject
    {
        public StaticObject(int owner, Point position) 
            : base(owner, position)
        {
        }
    }
}
