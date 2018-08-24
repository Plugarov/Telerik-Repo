using System;

namespace IsPrime
{
    class Program
    {
        static void Main()
        {

            string input = Console.ReadLine();
            int num = Int32.Parse(input);

            if (num == 0 || num == 1 || num < 0)
            {
                Console.WriteLine("false");
            }
            else
            {
                for (int i = 2; i < num - 1; i++)
                {

                    int devisor = i;
                    if (num % devisor == 0)
                    {
                        Console.WriteLine("false");
                        return;
                    }
                }
                Console.WriteLine("true");
            }
        }
    }
}
