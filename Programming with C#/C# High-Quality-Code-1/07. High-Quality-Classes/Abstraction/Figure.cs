namespace Figures
{
    using System;

    abstract class Figure : IFigure
    {
        protected Figure();

        protected abstract double CalcPerimeter();

        protected abstract double CalcSurface();

        public override ToString() {
            string output = string.Format("{0} -> Perimeter: {1}, Surface: {2}",
                this.GetType().Name, this.CalcPerimeter(), this.CalcSurface());
                
            return output;
        }
    }
}