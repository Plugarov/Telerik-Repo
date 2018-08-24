using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPassword
{
    class Program
    {
        static void Main()
        {
            int minPassLen = 8;
            int maxPassLen = 15;

            const string UPPER = "QWERTYUIOPASDFGHJKLZXCVBNM";
            const string LOWER = "qwertyuiopasdfghjklzxcvbnm";
            const string SYMBOLS = @"<>?:"" |}{P!@#$%^&*()";

            int upperLen = UPPER.Length;
            int lowerLen = LOWER.Length;
            int symbolLen = SYMBOLS.Length;

            StringBuilder password = new StringBuilder(0, maxPassLen);
            Random rand = new Random();
            int len = rand.Next(minPassLen, maxPassLen);
            int randomChar;
            int randomCharPos;

            for (int i = 0; i < len; i++)
            {
                randomCharPos = rand.Next(0, len);
                randomChar = rand.Next(0, upperLen);

                password.Insert(randomCharPos, UPPER[randomChar]);
            }

            Console.WriteLine(password);
        }
    }
}
