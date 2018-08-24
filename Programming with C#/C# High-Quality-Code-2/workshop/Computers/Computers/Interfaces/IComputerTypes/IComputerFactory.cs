namespace Computers.Interfaces
{
    using Computers.Components.ComputerTypes;

    public interface IComputerFactory
    {
        Laptop CreateLaptop();

        Server CreateServer();

        Pc CreatePc();
    }
}
