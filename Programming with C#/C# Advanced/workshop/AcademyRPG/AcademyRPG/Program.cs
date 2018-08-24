namespace AcademyRPG.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using AcademyRPG.Interfaces;

    class Program
    {

        public static void Main()
        {

            Engine engine = new Engine();
            engine.ExecuteCommand("create tree 10 (5,3)");
            engine.ExecuteCommand("create lumberjack Gogo (1,1) 1");
            engine.ExecuteCommand("create guard Jack (0,0) 1");
            //engine.ExecuteCommand("Jack go (4,2)");

            engine.ExecuteCommand("Gogo gather");

            foreach (IWorldObject v in engine.AllObjects)
            {
                Console.WriteLine(v.HitPoints);
                Console.WriteLine(v.IsDestroyed);
                Console.WriteLine(v.Position.X);
                Console.WriteLine(v.Position.Y);
                Console.WriteLine(" - - - - ");
            }

            //    engine.ExecuteCommand("bla blaa");

            //    engine.ExecuteCommand("create tree 10 (0,0)");
            //    engine.ExecuteCommand("create guard Jack (0,0) 1");
            //    engine.ExecuteCommand("create lumberjack <name> <position> <owner>");
            //    engine.ExecuteCommand("<name> go <position> ");
            //    engine.ExecuteCommand("<name> attack");
            //    engine.ExecuteCommand("<name> gather");
            //    engine.ExecuteCommand("create guard Jack (0,0) 1");
            //}
        }
    }
}
