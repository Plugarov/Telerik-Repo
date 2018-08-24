namespace Computers.ComputerFactory
{
    using System.Collections.Generic;

    using Computers.Components.ComputerTypes;
    using Computers.Components.Cpus;
    using Computers.Components.HardDrives;
    using Computers.Components.VideoCards;
    using Computers.Interfaces;

    public class HpFactory : IComputerFactory
    {
        public Server CreateServer()
        {
            Server server;
            var serverRam = new Ram(32);
            IVideoCard serverVideo = new MonochromeVideoCard();

            server = new Server(
            new Cpu32(
                4,
                serverRam,
                serverVideo),
            serverRam,
            new List<IHardDrive> {
                                    new RaidArray(
                                        new List<IHardDrive>
                                        {
                                            new HardDriver(1000),
                                            new HardDriver(1000)
                                        }) });
            return server;
        }

        public Laptop CreateLaptop()
        {
            Laptop laptop;

            var card = new ColorfullVideoCard();

            var ram1 = new Ram(4);

            laptop = new Laptop(
                new Cpu64(2, ram1, card),
                ram1,
                new[] { new HardDriver(500) },
                card,
                new LaptopBattery());

            return laptop;
        }

        public Pc CreatePc()
        {
            Pc pc;

            var ram = new Ram(2);
            var videoCard = new ColorfullVideoCard();

            pc = new Pc(
                 new Cpu32(2, ram, videoCard),
                 ram,
                 new[] { new HardDriver(500) },
                 videoCard);

            return pc;
        }
    }
}