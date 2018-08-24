namespace Computers.Components.ComputerTypes
{
    using System.Collections.Generic;

    using Computers.Components.Cpus;
    using Computers.Components.HardDrives;
    using Computers.Components.VideoCards;
    using Computers.Interfaces;

    public class Server : Computer
    {
        internal Server(
            Cpu cpu,
            Ram ram,
            IEnumerable<IHardDrive> hardDrives)
            : base(cpu, ram, hardDrives, new MonochromeVideoCard())
        {
        }

        internal void Process(int data)
        {
            this.Ram.SaveValue(data);
            Cpu.SquareNumber();
        }
    }
}
