namespace Figures
{
    using System;

    class Circle : Figure, IFigure
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius 
        {
            get 
            {
                return this.radius;
            }
            set
            {
                if (value <= 0) {
                    throw new ArgumentException("Radius can`t be negative value or zero.");
                }

                this.radius = value;
            }
        }

        public double CalcPerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;

            return perimeter;
        }

        public double CalcSurface()
        {
            double surface = Math.PI * this.Radius * this.Radius;

            return surface;
        }
        
        public override string ToString()
        {
            string output = string.Format("{0}, Radius: {1}", base.ToString(), this.Radius);
            return output;
        }
    }
}