using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRoot
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            try
            {
                Sqrt(num);
            }
            catch(Exception)
            {
                Console.WriteLine("Sqrt for negative numbers is undefined!");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }

        static void Sqrt(int num)
        {
            if (num <= 0)
                throw new Exception(); 

            Console.WriteLine("{0:0.000}", Math.Sqrt(num));
        }
    }
}
