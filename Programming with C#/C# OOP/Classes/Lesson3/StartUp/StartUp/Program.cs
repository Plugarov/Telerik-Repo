namespace StartUp
{
    using System;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class Program
    {
        public static void Main()
        {
            var assembly = Assembly.GetCallingAssembly();

            var allTypesThatHaveAnAuthor =
            assembly
            .GetTypes()
            .ToList();

            foreach (var myType in allTypesThatHaveAnAuthor)
            {
                Console.WriteLine(myType);
            }

            int firstNum = 12;
            int secondNum = 16;

            while (secondNum > 0)
            {
                int newNum = firstNum % secondNum;
                firstNum = secondNum;
                secondNum = newNum;
            }
            Console.WriteLine(firstNum);
        }
    }
}
