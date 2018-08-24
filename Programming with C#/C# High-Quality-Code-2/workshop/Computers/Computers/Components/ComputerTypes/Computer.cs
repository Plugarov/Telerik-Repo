namespace Computers.Components.ComputerTypes
{
    using System.Collections.Generic;
    
    using Computers.Components.Cpus;
    using Computers.Components.HardDrives;
    using Computers.Interfaces;

    public class Computer
    {
        internal Computer(
            ICpu cpu,
            Ram ram,
            IEnumerable<IHardDrive> hardDrives,
            IVideoCard videoCard)
        {
            this.Cpu = cpu;
            this.Ram = ram;
            this.HardDrives = hardDrives;
            this.VideoCard = videoCard;
        }

        public ICpu Cpu { get; set; }

        public Ram Ram { get; set; }

        public IEnumerable<IHardDrive> HardDrives { get; set; }

        internal IVideoCard VideoCard { get; set; }
    }
}
