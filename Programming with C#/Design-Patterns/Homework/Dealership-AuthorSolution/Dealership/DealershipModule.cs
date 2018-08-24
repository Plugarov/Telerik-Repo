using Dealership.Engine;
using Dealership.Engine.Commands;
using Dealership.Factories;
using Dealership.Models;
using InputAndOutputProvider;
using InputOutputProviderInterface;
using Interfaces.Commands;
using Interfaces.Contracts;
using Interfaces.Engine;

using Ninject;
using Ninject.Extensions.Factory;
using Ninject.Modules;

namespace Dealership
{
    internal class DealershipModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IEngine>().To<DealershipEngine>().InSingletonScope();
            Bind<IUserProvider>().To<UserProvider>().InSingletonScope();
            Bind<ICommand>().To<CommandHandler>();
            Bind<IRequestParser>().To<RequestParser>();
            Bind<IInputOutputProvider>().To<InputOutputProvider>();

            Bind<CommandHandler>().To<AddComment>().Named("AddComment");
            Bind<CommandHandler>().To<AddVehicle>().Named("AddVehicle");
            Bind<CommandHandler>().To<Login>().Named("Login");
            Bind<CommandHandler>().To<Logout>().Named("Logout");
            Bind<CommandHandler>().To<RegisterUser>().Named("RegisterUser");
            Bind<CommandHandler>().To<RemoveComment>().Named("RemoveComment");
            Bind<CommandHandler>().To<RemoveVehicle>().Named("RemoveVehicle");
            Bind<CommandHandler>().To<ShowUsers>().Named("ShowUsers");
            Bind<CommandHandler>().To<ShowVehicles>().Named("ShowVehicles");
            Bind<CommandHandler>().To<UserNotLogged>().Named("UserNotLogged");

            Bind<IDealershipFactory>().ToFactory().InSingletonScope();

            Bind<IUser>().To<User>();
            Bind<IComment>().To<Comment>();
            Bind<ITruck>().To<Truck>().Named("Truck");
            Bind<ICar>().To<Car>().Named("Car");
            Bind<IMotorcycle>().To<Motorcycle>().Named("Motorcycle");

            Bind<ICommand>().ToMethod(context =>
            {
                var userNotLogged = context.Kernel.Get<UserNotLogged>();
                var userProvider = context.Kernel.Get<UserProvider>();
                var register = context.Kernel.Get<RegisterUser>();
                var login = context.Kernel.Get<Login>();
                var logout = context.Kernel.Get<Logout>();
                var addVehicle = context.Kernel.Get<AddVehicle>();
                var removeVehicle = context.Kernel.Get<RemoveVehicle>();
                var addComment = context.Kernel.Get<AddComment>();
                var removeComment = context.Kernel.Get<RemoveComment>();
                var showUsers = context.Kernel.Get<ShowUsers>();
                var showVehicles = context.Kernel.Get<ShowVehicles>();
                var resetParameters = context.Kernel.Get<ResetProgramParameters>();

                userNotLogged.SetSuccessor(register);
                register.SetSuccessor(login);
                login.SetSuccessor(logout);
                logout.SetSuccessor(addVehicle);
                addVehicle.SetSuccessor(removeVehicle);
                removeVehicle.SetSuccessor(addComment);
                addComment.SetSuccessor(removeComment);
                removeComment.SetSuccessor(showUsers);
                showUsers.SetSuccessor(showVehicles);
                showVehicles.SetSuccessor(resetParameters);

                return userNotLogged;
            }).WhenInjectedInto<DealershipEngine>();

        }
    }
}