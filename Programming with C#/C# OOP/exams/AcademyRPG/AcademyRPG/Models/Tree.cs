namespace AcademyRPG.Models
{
    using System;
    using AcademyRPG.Interfaces;

    public class Tree : StaticObject, IStaticObject, IResource
    {
        public Tree(int owner, Point position, int size)
            : base(owner, position)
        {
            this.hitPoints = size;
        }

        protected int Size
        {
            get
            {
                return this.hitPoints;
            }
            set
            {
                this.hitPoints = value;
            }
        }

        public Type Type
        {
            get
            {
                return Type.Tree;
            }
        }

        public int Quantity
        {
            get
            {
                return this.Size;
            }
        }


    }

}
