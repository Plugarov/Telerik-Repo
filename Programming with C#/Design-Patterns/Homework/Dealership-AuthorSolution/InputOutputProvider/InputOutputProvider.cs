using InputOutputProviderInterface;
using System;

namespace InputAndOutputProvider
{
    public class InputOutputProvider : IInputOutputProvider
    {
        public string Read()
        {
            return Console.ReadLine();
        }

        public void Write(string input)
        {
            Console.WriteLine(input);
        }
    }
}
