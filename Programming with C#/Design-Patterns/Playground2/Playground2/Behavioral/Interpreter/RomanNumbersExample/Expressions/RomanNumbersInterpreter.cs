namespace Playground2.Behavioral.Interpreter.RomanNumbersExample.Expressions
{
    using System;
    using System.Collections.Generic;

    public class RomanNumbersInterpreter
    {
        private readonly IEnumerable<Expression> expressionTree;

        public RomanNumbersInterpreter(IEnumerable<Expression> expressionTree)
        {
            this.expressionTree = expressionTree;
        }

        public void Interpret(Context context)
        {
            // Interpret
            Console.WriteLine("Current context: Input={0} Output={1}", context.Input, context.Output);
            foreach (Expression expression in this.expressionTree)
            {
                expression.Interpret(context);
                Console.WriteLine("Current context: Input={0} Output={1}", context.Input, context.Output);
            }
        }
    }
}
