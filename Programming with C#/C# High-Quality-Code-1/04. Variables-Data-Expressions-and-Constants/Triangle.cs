//Refactor the following code to use proper variable naming and simplified expressions:

//public class Size
//{
//    public double wIdTh, Viso4ina;
//    public Size(double w, double h)
//    {
//        this.wIdTh = w;
//        this.Viso4ina = h;
//    }

//    public static Size GetRotatedSize(
//        Size s, double angleOfTheFigureThatWillBeRotaed)
//    {
//        return new Size(
//            Math.Abs(Math.Cos(angleOfTheFigureThatWillBeRotaed)) * s.wIdTh + 
//                Math.Abs(Math.Sin(angleOfTheFigureThatWillBeRotaed)) * s.Viso4ina,
//            Math.Abs(Math.Sin(angleOfTheFigureThatWillBeRotaed)) * s.wIdTh + 
//                Math.Abs(Math.Cos(angleOfTheFigureThatWillBeRotaed)) * s.Viso4ina);
//    }
//}

using System;

public class Triangle
{
    private double width, height;

    public Triangle(double width, double height)
    {
        this.Width = width;
        this.Height = height;
    }

    /// <summary>
    /// The width of the figure
    /// </summary>
    public double Width
    {
        get { return this.width; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Width must be greater than zero.");
            }

            this.width = value;
        }
    }

    /// <summary>
    /// The height of the figure
    /// </summary>
    public double Height
    {
        get { return this.height; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Height must be greater than zero.");
            }

            this.height = value;
        }
    }

    /// <summary>
    /// Rotate the triangle by given angle.
    /// </summary>
    /// <param name="triangle">Triangle object with height and width.</param>
    /// <param name="angleInDegrees">Angle of rotation.</param>
    /// <returns>New triangle after the rotation by specified angle.</returns>
    public Triangle Rotate(Triangle triangle, double rotationAngle)
    {
        var sinValue = Math.Abs(Math.Sin(rotationAngle));
        var cosValue = Math.Abs(Math.Cos(rotationAngle));

        var newWidth = cosValue * triangle.Width + sinValue * triangle.Height;
        var newHeight = sinValue * triangle.Width + cosValue * triangle.Height;

        Figure rotatedTriangle = new Triangle(newWidth, newHeight);

        return rotatedTriangle;
    }
}