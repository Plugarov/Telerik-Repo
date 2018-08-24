using Ninject;
using Ninject.Extensions.Conventions;
using Ninject.Extensions.Factory;
using Ninject.Extensions.Interception;
using Ninject.Parameters;
using System;

namespace Ninject
{
    public class Program
    {
        static void Main(string[] args)
        {

            IKernel kernel = new StandardKernel(new CustomerModule());

            // Easy way to create factory. No class created, only interface.
            IAutomobileFactory factory = kernel.Get<IAutomobileFactory>(); // Instead of NEW keyword

            IAutomobile instance = factory.CreateAutomobile("Honda", "Civic", 500);
            IAutomobile instance2 = factory.CreateAutomobile("Honda", "Jazz", 200);

            Console.WriteLine(instance.Price);
            Console.WriteLine(instance2.Price);

            // Inject dependency IInputOutputProvider into IWheaterDataProvider
            IWeatherDataProvider weather = kernel.Get<IWeatherDataProvider>();

            weather.DisplayWeatherInformation("Wonderful wheater");



        }
    }
}
