namespace Playground2.Behavioral.Interpreter.RomanNumbersExample.Expressions
{
    /// <summary>
    /// The 'Context' class
    /// </summary>
    public class Context
    {
        public Context(string input)
        {
            this.Input = input;
        }

        public string Input { get; set; }

        public int Output { get; set; }
    }
}
