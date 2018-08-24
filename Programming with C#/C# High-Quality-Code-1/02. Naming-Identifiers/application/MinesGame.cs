namespace MineGame
{
    using System;
    using System.Collections.Generic;

    public class MinesGame
    {
        public void Run()
        {
            string command = string.Empty;

            char[,] field = CreateFiled();
            char[,] mines = PlaceMines();

            int mineCounter = 0;
            bool isGameOver = false;

            List<Player> playerRankings = new List<Player>(6);
            int red = 0;
            int kolona = 0;
            const int maks = 35;

            bool flag = true;
            bool flag2 = false;

            do
            {
                if (flag)
                {
                    Console.WriteLine("Hajde da igraem na “Mini4KI”. Probvaj si kasmeta da otkriesh poleteta bez mini4ki." +
                    " command 'top' pokazva klasiraneto, 'restart' po4va nova igra, 'exit' izliza i hajde 4ao!");

                    PrintField(field);

                    flag = false;
                }

                Console.Write("Daj red i kolona : ");

                command = Console.ReadLine().Trim();

                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out red) &&
                    int.TryParse(command[2].ToString(), out kolona) &&
                        red <= field.GetLength(0) && kolona <= field.GetLength(1))
                    {
                        command = "turn";
                    }
                }
                switch (command)
                {
                    case "top":
                        GetResults(playerRankings);
                        break;
                    case "restart":
                        field = CreateFiled();
                        mines = PlaceMines();
                        PrintField(field);
                        isGameOver = false;
                        flag = false;
                        break;
                    case "exit":
                        Console.WriteLine("4a0, 4a0, 4a0!");
                        break;
                    case "turn":
                        if (mines[red, kolona] != '*')
                        {
                            if (mines[red, kolona] == '-')
                            {
                                tisinahod(field, mines, red, kolona);
                                mineCounter++;
                            }

                            if (maks == mineCounter)
                            {
                                flag2 = true;
                            }
                            else
                            {
                                PrintField(field);
                            }
                        }
                        else
                        {
                            isGameOver = true;
                        }
                        break;
                    default:
                        Console.WriteLine("\nGreshka! nevalidna command\n");
                        break;
                }

                if (isGameOver)
                {
                    PrintField(mines);

                    Console.Write("\nHrrrrrr! Umria gerojski s {0} to4ki. " +
                        "Daj si niknejm: ", mineCounter);

                    string niknejm = Console.ReadLine();

                    Player player = new Player(niknejm, mineCounter);

                    if (playerRankings.Count < 5)
                    {
                        playerRankings.Add(player);
                    }
                    else
                    {
                        for (int i = 0; i < playerRankings.Count; i++)
                        {
                            if (playerRankings[i].Points < player.Points)
                            {
                                playerRankings.Insert(i, player);
                                playerRankings.RemoveAt(playerRankings.Count - 1);
                                break;
                            }
                        }
                    }

                    playerRankings.Sort((Player r1, Player r2) => r2.Name.CompareTo(r1.Name));
                    playerRankings.Sort((Player r1, Player r2) => r2.Points.CompareTo(r1.Points));
                    GetResults(playerRankings);

                    field = CreateFiled();
                    mines = PlaceMines();
                    mineCounter = 0;
                    isGameOver = false;
                    flag = true;
                }
                if (flag2)
                {
                    Console.WriteLine("\nBRAVOOOS! Otvri 35 kletki bez kapka kryv.");

                    PrintField(mines);

                    Console.WriteLine("Daj si imeto, batka: ");

                    string name = Console.ReadLine();
                    Player playerRank = new Player(name, mineCounter);

                    playerRankings.Add(playerRank);

                    GetResults(playerRankings);

                    field = CreateFiled();
                    mines = PlaceMines();

                    mineCounter = 0;

                    flag2 = false;
                    flag = true;
                }
            }
            while (command != "exit");

            Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
            Console.WriteLine("AREEEEEEeeeeeee.");
            Console.Read();
        }

        private static void GetResults(List<Player> to4kii)
        {
            Console.WriteLine("\n Results:");
            if (to4kii.Count > 0)
            {
                for (int i = 0; i < to4kii.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} kutii",
                        i + 1, to4kii[i].Name, to4kii[i].Points);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("prazna klasaciq!\n");
            }
        }

        private static void tisinahod(char[,] POLE,
            char[,] BOMBI, int RED, int KOLONA)
        {
            char kolkoBombi = kolko(BOMBI, RED, KOLONA);
            BOMBI[RED, KOLONA] = kolkoBombi;
            POLE[RED, KOLONA] = kolkoBombi;
        }

        private static void PrintField(char[,] board)
        {
            int RRR = board.GetLength(0);
            int KKK = board.GetLength(1);

            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");

            for (int i = 0; i < RRR; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < KKK; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }
                Console.Write("|");
                Console.WriteLine();
            }
            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreateFiled()
        {
            int rows = 5;
            int cols = 10;
            char[,] field = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    field[i, j] = '?';
                }
            }

            return field;
        }

        private static char[,] PlaceMines()
        {
            int rows = 5;
            int cols = 10;
            const short mineQuantity = 15;

            char[,] field = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    field[i, j] = '-';
                }
            }

            List<int> minesCoordinates = new List<int>();

            while (minesCoordinates.Count < mineQuantity)
            {
                Random random = new Random();
                int randomMinePosition = random.Next(rows * cols);

                if (!minesCoordinates.Contains(randomMinePosition))
                {
                    minesCoordinates.Add(randomMinePosition);
                }
            }

            foreach (int mine in minesCoordinates)
            {
                int col = (mine / cols);
                int row = (mine % cols);

                if (row == 0 && mine != 0)
                {
                    col--;
                    row = cols;
                }
                else
                {
                    row++;
                }

                field[col, row - 1] = '*';
            }

            return field;
        }

        private static void smetki(char[,] pole)
        {
            int kol = pole.GetLength(0);
            int red = pole.GetLength(1);

            for (int i = 0; i < kol; i++)
            {
                for (int j = 0; j < red; j++)
                {
                    if (pole[i, j] != '*')
                    {
                        char kolkoo = kolko(pole, i, j);
                        pole[i, j] = kolkoo;
                    }
                }
            }
        }

        private static char kolko(char[,] r, int rr, int rrr)
        {
            int brojkata = 0;
            int reds = r.GetLength(0);
            int kols = r.GetLength(1);

            if (rr - 1 >= 0)
            {
                if (r[rr - 1, rrr] == '*')
                {
                    brojkata++;
                }
            }
            if (rr + 1 < reds)
            {
                if (r[rr + 1, rrr] == '*')
                {
                    brojkata++;
                }
            }
            if (rrr - 1 >= 0)
            {
                if (r[rr, rrr - 1] == '*')
                {
                    brojkata++;
                }
            }
            if (rrr + 1 < kols)
            {
                if (r[rr, rrr + 1] == '*')
                {
                    brojkata++;
                }
            }
            if ((rr - 1 >= 0) && (rrr - 1 >= 0))
            {
                if (r[rr - 1, rrr - 1] == '*')
                {
                    brojkata++;
                }
            }
            if ((rr - 1 >= 0) && (rrr + 1 < kols))
            {
                if (r[rr - 1, rrr + 1] == '*')
                {
                    brojkata++;
                }
            }
            if ((rr + 1 < reds) && (rrr - 1 >= 0))
            {
                if (r[rr + 1, rrr - 1] == '*')
                {
                    brojkata++;
                }
            }
            if ((rr + 1 < reds) && (rrr + 1 < kols))
            {
                if (r[rr + 1, rrr + 1] == '*')
                {
                    brojkata++;
                }
            }
            return char.Parse(brojkata.ToString());
        }
    }
}