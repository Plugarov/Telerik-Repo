namespace Computers.Components.Cpus
{
    using System;

    using Computers.Components.HardDrives;
    using Computers.Interfaces;

    public abstract class Cpu : ICpu
    {
        private static readonly Random Random = new Random();

        public Cpu(
            byte numberOfCores,
            IRam ram,
            IVideoCard videoCard)
        {
            this.NumberOfCores = numberOfCores;
            this.Ram = ram;
            this.VideoCard = videoCard;
        }

        public byte NumberOfCores { get; private set; }

        public IRam Ram { get; private set; }

        public IVideoCard VideoCard { get; private set; }

        public abstract void SquareNumber();

        public void Rand(int a, int b)
        {
            int randomNumber = Random.Next(a, b + 1);

            this.Ram.SaveValue(randomNumber);
        }
    }
}
