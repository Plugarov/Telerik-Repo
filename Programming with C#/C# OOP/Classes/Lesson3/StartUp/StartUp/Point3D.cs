namespace StartUp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal struct Point3D
    {
        private static readonly int[,,] ThreeDimensionalSpace;
        //private readonly int insta;

        static Point3D()
        {
            ThreeDimensionalSpace = new int[0, 0, 0];
        }

        public static int[,,] PrintDimension()
        {
            return ThreeDimensionalSpace;
        }
        
        //Using constructor for readonly
        //public Point3D(int a)
        //{
        //    insta = a;
        //}
    }
}

