namespace Computers.Components.Cpus
{
    using Computers.Components.HardDrives;
    using Computers.Interfaces;

    public class Cpu64 : Cpu, ICpu
    {
        public Cpu64(
            byte numberOfCores,
            IRam ram,
            IVideoCard videoCard)
            : base(numberOfCores, ram, videoCard)
        {
        }

        public override void SquareNumber()
        {
            var data = this.Ram.LoadValue();

            if (data < 0)
            {
                this.VideoCard.Draw("Number too low.");
            }
            else if (data > 1000)
            {
                this.VideoCard.Draw("Number too high.");
            }
            else
            {
                int value = 0;
                for (int i = 0; i < data; i++)
                {
                    value += data;
                }

                this.VideoCard.Draw(string.Format("Square of {0} is {1}.", data, value));
            }
        }
    }
}