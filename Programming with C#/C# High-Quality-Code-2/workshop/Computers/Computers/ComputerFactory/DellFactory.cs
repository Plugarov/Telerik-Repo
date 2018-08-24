namespace Computers
{
    using System.Collections.Generic;

    using Computers.Components.ComputerTypes;
    using Computers.Components.Cpus;
    using Computers.Components.HardDrives;
    using Computers.Components.VideoCards;
    using Computers.Interfaces;

    public class DellFactory : IComputerFactory
    {
        public Laptop CreateLaptop()
        {
            Laptop laptop;
            var ram2 = new Ram(8);
            var videoCard1 = new ColorfullVideoCard();

            laptop = new Laptop(
                new Cpu32(2, ram2, videoCard1),
                ram2,
                new[] { new HardDriver(1000) },
                videoCard1,
                new LaptopBattery());

            return laptop;
        }

        public Pc CreatePc()
        {
            Pc pc;

            var factory = new DellFactory();
            var ram = new Ram(8);
            var videoCard = new ColorfullVideoCard();

            pc = new Pc(new Cpu64(4, ram, videoCard), ram, new[] { new HardDriver(1000) }, videoCard);

            return pc;
        }

        public Server CreateServer()
        {
            Server server;

            var ram1 = new Ram(64);
            var card = new MonochromeVideoCard();

            server = new Server(
                new Cpu64(8, ram1, card),
                ram1,
                new List<IHardDrive>
                {
                        new RaidArray(
                            new List<IHardDrive>
                            {new HardDriver(2000), new HardDriver(2000)})});

            return server;
        }
    }
}