using System;

namespace Playground2.Structural.Decorator
{
    public class Robot : IRobot
    {
        public Robot()
        {
        }

        public IRobot Instance { get; set; }

        public void Shoot()
        {
            Console.WriteLine("Shoot!");
        }

        public void Introduce(string input)
        {
            Console.WriteLine(string.Format("I`m lazy robot {0}.", input));
        }
    }

    public class DancingRobot : IRobot
    {
        public DancingRobot(IRobot instance)
        {
            this.Instance = instance;

        }

        public IRobot Instance { get; set; }

        public void Introduce(string input)
        {
            this.Instance.Introduce(input);
            Console.WriteLine("BTW, I`m dancing one.");
        }
    }

    public class DancingAndShootingRobot : IRobot
    {
        public DancingAndShootingRobot(IRobot instance)
        {
            this.Instance = instance;
        }

        public IRobot Instance { get; set; }

        public void Introduce(string input)
        {
            this.Instance.Introduce(input);
            Console.WriteLine("And i can shoot ya.");
        }
    }

    public interface IRobot
    {
        void Introduce(string input);
    }
}
