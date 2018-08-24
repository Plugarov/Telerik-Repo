using Homework.Interfaces;
using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape figure = new Triangle();

            var areaCalculator = new RandomFigureAreaCalculator(figure);

            areaCalculator.CalculateArea();
        }
    }

    public class RandomFigureAreaCalculator
    {
        private IShape shape;

        public RandomFigureAreaCalculator(IShape shape)
        {
            this.shape = shape;
        }

        public int CalculateArea()
        {
            string figure = this.shape.GetType().Name;

            switch (figure)
            {
                case "Triangle":
                    return 5;
                case "Circle":
                    return 6;
                default:
                    return 10;
            }
        }
    }
}
