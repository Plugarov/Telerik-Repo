namespace CohesionAndCoupling
{
    using System;
    
    public class RectangularParallelepiped
    {
        private double width;
        private double height;
        private double depth;

        public RectangularParallelepiped(double width, dobule height, double depth)
        {
            this.Width = width;
            this.Height = height;
            this.Depth = depth;
        }

        public double Width 
        { 
            get
            {
                return this.width;
            } 
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentException("Width should be more than 0.");
                }
            } 
        }

        public double Height 
        {
            get
            {
                return this.height;
            } 
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentException("Height should be more than 0.");
                }
            } 
        }

        public double Depth 
        { 
            get
            {
                return this.depth;
            } 
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentException("Depth should be more than 0.");
                }
            } 
        }

        public double CalcVolume()
        {
            double volume = this.Width * this.Height * this.Depth;
            return volume;
        }

        public double CalcDiagonalXYZ()
        {
            double distance = CalcDistance3D(0, 0, 0, this.Width, this.Height, this.Depth);
            return distance;
        }

        public double CalcDiagonalXY()
        {
            double distance = CalcDistance2D(0, 0, this.Width, this.Height);
            return distance;
        }

        public double CalcDiagonalXZ()
        {
            double distance = CalcDistance2D(0, 0, this.Width, this.Depth);
            return distance;
        }

        public double CalcDiagonalYZ()
        {
            double distance = CalcDistance2D(0, 0, this.eight, this.Depth);
            return distance;
        }

        public override ToString()
        {
            string output = string.Format("This {0} has width: {1}, height: {2} and depth: {3}", 
                this.GetType().Name, this.Width, this.Height, this.Depth);
            return output;
        }
    }
}