using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReplaceSubString
{
    class Program
    {
        static void Main()
        {
            //DateTime startOver = DateTime.Now;
            //for (int i = 0; i < 2000; i++)
            //{
            //    using (StreamReader streamReader = new StreamReader(@"C:\Users\7\Desktop\result.txt"))
            //    {
            //        using (StreamWriter streamWriter = new StreamWriter(@"C:\Users\7\Desktop\res.txt"))
            //        {
            //            string line = streamReader.ReadLine();

            //            while (line != null)
            //            {
            //                streamWriter.WriteLine(line.Replace("Peter", "Peter dead"));
            //                line = streamReader.ReadLine();
            //            }
            //        }
            //    }

            //}
            //DateTime endOver = DateTime.Now;
            //Console.WriteLine(endOver - startOver);

            DateTime start = DateTime.Now;
            for (int i = 0; i < 2000; i++)
            {
                string read = File.ReadAllText(@"C:\Users\7\Desktop\result.txt");
                string replaced = read.Replace("Peter", "Peter dead");
                File.WriteAllText(@"C:\Users\7\Desktop\res.txt", replaced);
            }
            DateTime end = DateTime.Now;
            Console.WriteLine(end - start);

        }
    }
}
