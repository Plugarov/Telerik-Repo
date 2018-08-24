﻿namespace Playground2.Behavioral.Command
{
    using System;
    using Playground2.Behavioral.Command.CalculatorExample;
    using Playground2.Behavioral.Command.SwitchExample;

    static class Command
    {
        public static void Run()
        {
            SwitchExample();
            Console.WriteLine(new string('-', 60));
            CalculatorExample();
        }

        private static void SwitchExample()
        {
            ISwitchable lamp = new Light();

            // Pass reference to the lamp instance to each command
            ICommand switchClose = new CloseSwitchCommand(lamp);
            ICommand switchOpen = new OpenSwitchCommand(lamp);

            // Pass reference to instances of the Command objects to the switch
            var @switch = new Switch();

            Console.Write("Please enter the number of commands: ");
            var numberOfCommands = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfCommands; i++)
            {
                Console.Write("Please enter command (OPEN or CLOSE): ");
                var arg = Console.ReadLine(); // OPEN or CLOSE
                if (arg == "OPEN")
                {
                    // Switch (the Invoker) will invoke Execute() (the Command) on the command object
                    @switch.StoreAndExecute(switchOpen);
                }
                else if (arg == "CLOSE")
                {
                    // Switch (the Invoker) will invoke the Execute() (the Command) on the command object
                    @switch.StoreAndExecute(switchClose);
                }
                else
                {
                    Console.WriteLine("Argument \"OPEN\" or \"CLOSE\" is required.");
                }
            }

            Console.WriteLine("Undoing commands...");
            foreach (ICommand command in @switch.History)
            {
                command.UnExecute();
            }
        }

        private static void CalculatorExample()
        {
            var user = new User();
            user.Compute('+', 100);
            user.Compute('-', 50);
            user.Compute('*', 10);
            user.Compute('/', 2);
            user.Undo(4);
            user.Redo(3);
        }
    }
}
