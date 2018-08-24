//Task 4. Re-factor and improve the code
//Refactor and improve the naming in the C# source project Application1.sln.
//You are allowed to make other improvements in the code as well(not only naming) as well as to fix bugs.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new MinesGame();

            game.Run();
        }
    }
}
