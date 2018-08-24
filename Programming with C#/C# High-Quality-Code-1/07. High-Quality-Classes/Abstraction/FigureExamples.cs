namespace Figures
{
    using System;
    
    class FiguresExample
    {
        static void Main()
        {
            Circle circle = new Circle(5);
            Rectangle rectangle = new Rectangle(2, 3);

            Console.WriteLine(circle.ToString());
            Console.WriteLine(rectangle.ToString());
        }
    }
}