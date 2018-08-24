namespace Computers
{
    using System;

    using Computers.ComputerFactory;
    using Computers.Interfaces;

    public class Program
    {
        public static void Main()
        {
            var manufacturer = Console.ReadLine();
            IComputerFactory factory = CreateFactory(manufacturer);

            var laptop = factory.CreateLaptop();
            var pc = factory.CreatePc();
            var server = factory.CreateServer();

            while (true)
            {
                var c = Console.ReadLine();

                if (c == null)
                {
                    break;
                }

                if (c.StartsWith("Exit"))
                {
                    break;
                }

                var cp = c.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (cp.Length != 2)
                {
                    {
                        throw new ArgumentException("Invalid command!");
                    }
                }

                var cn = cp[0];
                var ca = int.Parse(cp[1]);

                if (cn == "Charge")
                {
                    laptop.ChargeBattery(ca);
                }
                else if (cn == "Process")
                {
                    server.Process(ca);
                }
                else if (cn == "Play")
                {
                    pc.Play(ca);
                }
                else
                {
                    Console.WriteLine("Invalid command!");
                }
            }
        }

        private static IComputerFactory CreateFactory(string manufacturer)
        {
            IComputerFactory factory;

            if (manufacturer == "HP")
            {
                factory = new HpFactory();
            }
            else if (manufacturer == "Dell")
            {
                factory = new DellFactory();
            }
            else
            {
                throw new InvalidArgumentException("Invalid manufacturer!");
            }

            return factory;
        }
    }
}