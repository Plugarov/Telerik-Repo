using Ninject.Extensions.Factory;
using Ninject.Modules;
using Ninject.Extensions.Conventions;
using System.IO;
using System.Reflection;

namespace Ninject
{
    internal class CustomerModule : NinjectModule
    {
        public override void Load()
        {
            // Following code fragment automatically binds interfaces to classes:

            //Kernel.Bind(x =>
            //{
            //    x.FromAssembliesInPath(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location))
            //    .SelectAllClasses()
            //    .BindDefaultInterface();
            //});

            // Instead of:
            // Bind<IAutomobile>().To<Automobile>();
            // Bind<IAutomobileFactory>().ToFactory().InSingletonScope();
            // etc.

            // Easy way to create factory. No class created, only interface.
            Bind<IAutomobile>().To<Automobile>();
            Bind<IAutomobileFactory>().ToFactory().InSingletonScope();


            // Inject dependency IInputOutputProvider into IWheaterDataProvider
            Bind<IWeatherDataProvider>().To<WeatherDataProvider>();
            Bind<IInputOutputProvider>().To<InputOutputProvider>();
            Bind<IInputOutputProvider>().ToMethod(context =>
            {
                IInputOutputProvider inputOutputProvider = context.Kernel.Get<IInputOutputProvider>(); // Instead of NEW keyword

                return inputOutputProvider;
            }).WhenInjectedInto<IWeatherDataProvider>();


        }
    }
}