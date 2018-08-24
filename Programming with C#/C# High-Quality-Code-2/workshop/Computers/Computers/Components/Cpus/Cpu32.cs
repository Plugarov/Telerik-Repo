namespace Computers.Components.Cpus
{
    using Computers.Components.HardDrives;
    using Computers.Interfaces;

    public class Cpu32 : Cpu, ICpu, ICpu32
    {
        public Cpu32(
            byte numberOfCores,
            Ram ram,
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
            else if (data > 500)
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