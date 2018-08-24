namespace Computers.Components.ComputerTypes
{
    using System.Collections.Generic;

    using Computers.Components.Cpus;
    using Computers.Components.HardDrives;
    using Computers.Interfaces;

    public class Pc : Computer
    {
        internal Pc(
            Cpu cpu,
            Ram ram,
            IEnumerable<IHardDrive> hardDrives,
            IVideoCard videoCard)
            : base(cpu, ram, hardDrives, videoCard)
        {
        }

        public void Play(int guessNumber)
        {
            Cpu.Rand(1, 10);
            var number = this.Ram.LoadValue();

            if (number != guessNumber)
            {
                this.VideoCard.Draw(string.Format("You didn't guess the number {0}.", number));
            }
            else
            {
                this.VideoCard.Draw("You win!");
            }
        }
    }
}
