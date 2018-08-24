using Playground2.Prototype;
using System;

namespace Playground2.Creational.Prototype
{
    public static class PrototypeMain
    {
        public static void Run()
        {
            ConcretePrototype1 p1 = new ConcretePrototype1("i");
            ConcretePrototype1 c1 = (ConcretePrototype1)p1.Clone();
            Console.WriteLine("cloned: {0}", c1.Id);

            ConcretePrototype2 p2 = new ConcretePrototype2("ii");
            ConcretePrototype2 c2 = (ConcretePrototype2)p2.Clone();
            Console.WriteLine("cloned: {0}", c2.Id);
        }
    }
}
