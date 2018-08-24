using Playground2.AbstractFactoryNamespace;

namespace Playground2.Creational.AbstractFactoryNamespace
{
    public static class AbstractFactoryMain
    {
        public static void Run()
        {
            //https://www.codeproject.com/Articles/328373/Understanding-and-Implementing-Abstract-Factory-Pa

            AbstractFactory factory1 = new ConcreteFactory1();
            Client client1 = new Client(factory1);
            client1.Run();

            // Abstract factory #2

            var factory2 = new ConcreteFactory2();
            Client client2 = new Client(factory2);
            client2.Run();
        }
    }
}
