using Playground2.Behavioral.Interpreter.PolishNotationExample;
using Playground2.Behavioral.Interpreter.PolishNotationExample.Expressions;
using Playground2.Behavioral.Interpreter.RomanNumbersExample.Expressions;
using System;
using System.Collections.Generic;

namespace Playground2.Behavioral.Interpreter
{
    public static class Interpreter
    {
        public static void Run()
        {
            RomanNumbersExample();
            Console.WriteLine(new string('-', 60));
            PolishNotationExample();
        }

        private static void RomanNumbersExample()
        {
            var romanNumbersInterpreter =
                new RomanNumbersInterpreter(
                    new List<Expression>
                        {
                            new ThousandExpression(),
                            new HundredExpression(),
                            new TenExpression(),
                            new OneExpression()
                        });

            const string Input = "MMCMXXVIII";
            var context = new Context(Input);

            romanNumbersInterpreter.Interpret(context);

            Console.WriteLine();
            Console.WriteLine("Final: {0} = {1}", Input, context.Output);
        }

        // Also called Prefix notation
        private static void PolishNotationExample()
        {
            var parser = new PolishNotationParser();

            string[] commands =
            {
                "+ 5 6",
                "- 6 5",
                "+ - 4 5 6",
                "+ 4 - 5 6",
                "+ - + - - 2 3 4 + - -5 6 + -7 8 9 10"
            };

            foreach (string command in commands)
            {
                ExpressionBase expression = parser.Parse(command);
                Console.WriteLine(command);
                Console.WriteLine(expression);
                Console.WriteLine(expression.Evaluate());
                Console.WriteLine();
            }
        }
    }
}
