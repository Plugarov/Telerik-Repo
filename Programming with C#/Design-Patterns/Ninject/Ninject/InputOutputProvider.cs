using System;

namespace Ninject
{
    public class InputOutputProvider : IInputOutputProvider
    {
        public void Write(string input)
        {
            Console.WriteLine(input);
        }

        public string Read()
        {
            return Console.ReadLine();
        }
    }
}
