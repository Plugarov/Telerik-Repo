namespace Math
{
    using System;

    public class ShapeUtilities
    {
        private static bool isHorizontal;
        private static bool isVertical;

        private static bool IsVertical
        {
            get
            {
                return isVertical;
            }

            private set
            {
                this.isVertical = value;
            }
        }
        private static bool IsHorizontal
        {
            get
            {
                return isHorizontal;
            }

            private set
            {
                this.isHorizontal = value;
            }
        }

        static double CalcTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentOutOfRangeException("Sides should be positive.");
            }

            if (a + b <= c ||
                b + c <= a ||
                c + a <= b)
            {
                throw new ArgumentException("Invalid triangle sides size.");
            }

            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            return area;
        }

        static double CalcDistance(double x1, double y1, double x2, double y2)
        {
            this.IsHorizontal = (y1 == y2);
            this.IsVertical = (x1 == x2);

            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));

            return distance;
        }

        public static bool AreTwoPointsHorizontal(Point p1, Point p2)
        {
            return this.IsHorizontal;
        }

        public static bool AreTwoPointsVertical(Point p1, Point p2)
        {
            return this.IsVertical;
        }
    }
}