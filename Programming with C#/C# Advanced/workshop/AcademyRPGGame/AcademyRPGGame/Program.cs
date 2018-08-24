namespace AcademyRPG
{
    using System;
    using System.IO;

    class Program
    {
        public static Engine GetEngineInstance()
        {
            return new ExtendEngine();
        }

        static void Main(string[] args)
        {

            using (var sw = new StreamWriter("../../test.out.txt"))
            {
                Console.SetOut(sw);

                Engine engine = GetEngineInstance();

                string command = Console.ReadLine();
                while (command != "end")
                {
                    engine.ExecuteCommand(command);
                    command = Console.ReadLine();
                }
            }
        }
    }
}
