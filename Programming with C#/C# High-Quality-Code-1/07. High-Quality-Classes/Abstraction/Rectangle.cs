namespace Figures
{
    using System;
    
    class Rectangle : Figure, IFigure
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width 
        { 
            get 
            {
                return this.width;
            }
            set
            {
                if (value <= 0) {
                    throw new ArgumentException("Width can`t be negative value or zero.");
                }

                this.width = value;
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
                if (value <= 0) {
                    throw new ArgumentException("Height can`t be negative value or zero.");
                }

                this.height = value;
                
            } 
        }

        public double CalcPerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);
            
            return perimeter;
        }

        public double CalcSurface()
        {
            double surface = this.Width * this.Height;
            
            return surface;
        }

        public override string ToString()
        {
            string output = string.Format("{0}, Width: {1}, Height: {2}",
                base.ToString(), this.Width, this.Height);
            return output;
        }
    }
}