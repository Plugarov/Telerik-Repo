
namespace Generics
{
    using System;

    class Program
    {
        static void Main()
        {
            // You can dynamicly change types used in the Box

            //var box = new Box<string>();
            var box = new Box<int>();

            //box.push("1");
            //box.push("2");
            //box.push("3"); 
            //box.push("4");

            box.push(1);
            box.push(2);
            box.push(3);
            box.push(4);

            box.pop();
            box.print();

            // Overloading basic
            var catOne = new Cat(Gender.female);
            var catTwo = new Cat(Gender.male);
            var result = catOne + catTwo;
            Console.WriteLine(result.getGender);

            //TODO Fractions Overloading
            var firstFraction = new FractionsMyImpl(5, 10);
            var secondFraction = new FractionsMyImpl(7, 15);

            var multiplyFractions = firstFraction * secondFraction;
            Console.WriteLine("---");
            Console.WriteLine(multiplyFractions.getNumerator);
            Console.WriteLine(multiplyFractions.getDenumerator);
            Console.WriteLine("---");

            // Matrix
            int rows = 3;
            int cols = 3;

            var matrix = new Matrix<string>(rows, cols);
            var matrix2 = new Matrix<string>(rows, cols);
            Print.Matrix(matrix2);

            var sumMatrixies = matrix + matrix2;
            Print.Matrix(sumMatrixies);
            Console.WriteLine("---");


        }

    }

    class Print
    {
        public static void Matrix(Matrix<string> matrix)
        {
            for (int i = 0; i < matrix.getRows; i++)
            {
                for (int y = 0; y < matrix.getCols; y++)
                {
                    Console.Write(matrix[i, y] + "0 ");
                }
                Console.WriteLine();
            }
        }
    }

}