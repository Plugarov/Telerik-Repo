namespace StartUp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    [Author("Ivan Kolev")]
    internal class Dimension : System.Attribute
    {
        private int[,,] spaceDimension;

        public Dimension(int x, int y, int z)
        {
            this.spaceDimension = new int[x, y, z];
        }

        public int GetCoordinatesX
        {
            get { return this.spaceDimension.GetLength(0); }
        }

        public int GetCoordinatesY
        {
            get { return this.spaceDimension.GetLength(1); }
        }

        public int GetCoordinatesZ
        {
            get { return this.spaceDimension.GetLength(2); }
        }

        public static Dimension operator +(Dimension d1, Dimension d2)
        {
            return new Dimension(1, 2, 3);
        }

        public int[,,] ReturnDimension()
        {
            return this.spaceDimension;
        }
    }
}
