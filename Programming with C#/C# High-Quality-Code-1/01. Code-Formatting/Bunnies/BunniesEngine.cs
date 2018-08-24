namespace High.Quality.Code.BadExample
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.Text;
    using System.Threading.Tasks;

    public class Bunnies
    {
        static void Main()
        {
            var bunnies = new List<Bunny> {
                new Bunny {Name = "Leonid", Age= 1, FurType = FurType.NotFluffy},
                new Bunny {Name = "Rasputin", Age= 2,  FurType = FurType.ALittleFluffy},
                new Bunny {Name = "Tiberii", Age= 3, FurType = FurType.ALittleFluffy},
                new Bunny {Name = "Vespasian", Age= 3, FurType = FurType.Fluffy},
                new Bunny {Name = "Neron", Age= 1,FurType = FurType.ALittleFluffy},
                new Bunny {Name = "Klavdii", Age= 3, FurType = FurType.Fluffy},
                new Bunny {Name = "Domician", Age = 4, FurType = FurType.FluffyToTheLimit},
                new Bunny {Name = "Tit", Age= 2, FurType = FurType.FluffyToTheLimit}
            };

            var bunniesFilePath = @"..\..\bunnies.txt";

            PrintBunnyInfo(bunnies);
            WriteBuunyInfoToFile(path, bunnies);
        }

        public void PrintBunnyInfo(Bunny bunnies)
        {
            var consoleWriter = new ConsoleWriter();

            foreach (var bunny in bunnies)
            {
                bunny.Introduce(consoleWriter);
            }
        }

        public void WriteBuunyInfoToFile(string bunniesFilePath, Bunny bunnies)
        {
            var fileStream = File.Create(bunniesFilePath);

            fileStream.Close();

            var streamWriter = new StreamWriter(bunniesFilePath);
            using (streamWriter)
            {
                foreach (var bunny in bunnies)
                {
                    streamWriter.WriteLine(bunny.ToString());
                }
            }
        }
    }
}