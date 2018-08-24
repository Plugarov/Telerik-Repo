using Playground2.FactoryMethod;
using System;
namespace Playground2.Creational.FactoryMethod
{
    class FactoryMethodMain
    {
        internal static void Run()
        {
            Creator[] creators = new Creator[2];

            creators[0] = new ConcreteCreatorA();
            creators[1] = new ConcreteCreatorB();

            // Iterate over creators and create products

            foreach (Creator creator in creators)
            {
                Product product = creator.FactoryMethod();
                Console.WriteLine("Created {0}",
                  product.GetType().Name);
            }

            Console.ReadKey();
        }
    }
}
