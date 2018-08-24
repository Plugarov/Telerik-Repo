namespace Computers.Components.ComputerTypes
{
    using System.Collections.Generic;
    
    using Computers.Components.Cpus;
    using Computers.Components.HardDrives;
    using Computers.Interfaces;

    public class Laptop : Computer
    {
        private readonly LaptopBattery battery;

        internal Laptop(
            Cpu cpu,
            Ram ram,
            IEnumerable<IHardDrive> hardDrives,
            IVideoCard videoCard,
            LaptopBattery battery)
            : base(cpu, ram, hardDrives, videoCard)
        {
            this.battery = battery;
        }

        internal void ChargeBattery(int percentage)
        {
            this.battery.Charge(percentage);
            this.VideoCard.Draw(string.Format("Battery status: {0}", this.battery.Percentage));
        }
    }
}
