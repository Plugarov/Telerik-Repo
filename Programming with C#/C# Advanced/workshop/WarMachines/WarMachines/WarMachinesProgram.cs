namespace WarMachines
{
    using System;
    using WarMachines.Engine;

    using WarMachines.Interfaces;
    using WarMachines.Machines;

    public class WarMachinesProgram
    {
        public static void Main()
        {

            //WarMachineEngine.Instance.Start();

            var a = new Pilot("Stepan");
            ITank m = new Tank("ARMATA", 100, 100);
            ITank b = new Tank("T72", 55, 22);
            IFighter f = new Fighter("Ninja", 55, 44, false);
            //m.Attack("T-72");
            Console.WriteLine(a.Report());
            a.AddMachine(m);
            m.Attack("USA");
            a.AddMachine(b);
            a.AddMachine(f);

            m.ToggleDefenseMode();
            m.Pilot = a;

            Console.WriteLine(a.Report());
        }
    }
}
