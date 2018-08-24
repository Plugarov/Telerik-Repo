using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SaveSortedNames
{
    class Program
    {
        static void Main()
        {
            WriteSortNames(SortNames());
        }

        static List<string> SortNames()
        {
            string path = @"C:\Users\7\Desktop\result.txt";
            Encoding encode = Encoding.UTF8;

            List<string> names = new List<string>();
            StreamReader reader = new StreamReader(path, encode);
            using (reader)
            {
                string name = reader.ReadLine();

                while (name != null)
                {
                    names.Add(name);
                    name = reader.ReadLine();
                }
                names.Sort();
            }
            return names;
        }

        static void WriteSortNames(List<string> names)
        {
            string path = @"C:\Users\7\Desktop\res.txt";
            bool append = true;
            Encoding encode = Encoding.UTF8;
            StreamWriter writer = new StreamWriter(path, append, encode);

            using (writer)
            {
                for (int i = 0; i < names.ToArray().Length; i++)
                {
                    writer.WriteLine(names[i]);
                }
            }
        }
    }
}
