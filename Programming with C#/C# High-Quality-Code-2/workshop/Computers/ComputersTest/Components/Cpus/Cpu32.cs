namespace ComputersTest.Components.Cpus
{
    using Computers.Components.Cpus;
    using Computers.Components.HardDrives;
    using Computers.Components.VideoCards;
    using Computers.Interfaces;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;

    [TestClass]
    public class Cpu32Tests
    {

        [TestMethod]
        public void SquareNumber()
        {
            // Arrange
            Ram ram = new Ram(400);
            byte cores = 4;
            IVideoCard videoCard = new ColorfullVideoCard();

            ICpu cpu = new Cpu32(cores, ram, videoCard);

            cpu.SquareNumber();

        }
    }
}
