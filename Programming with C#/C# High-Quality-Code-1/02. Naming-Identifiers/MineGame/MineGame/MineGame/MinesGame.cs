namespace MineGame
{
    using System;
    using System.Collections.Generic;

    internal class MinesGame
    {
        private string command;

        private char[,] gameField;
        private char[,] mines;

        private int mineCounter;

        private bool isGameOver;
        private List<Player> playerRankings;

        private int selectedRow;
        private int selectedCol;

        private bool flag;
        private bool flag2;

        private int maximumPossiblePoints;

        public MinesGame()
        {
            this.command = string.Empty;

            this.gameField = CreateGameFiled();
            this.mines = PlaceMines();

            this.mineCounter = 0;

            this.isGameOver = false;
            this.playerRankings = new List<Player>(6);

            this.selectedRow = 0;
            this.selectedCol = 0;

            this.flag = true;
            this.flag2 = false;

            this.maximumPossiblePoints = 35;

        }

        internal void Run()
        {
            do
            {
                if (this.flag)
                {
                    Console.WriteLine("Hajde da igraem na “Mini4KI”. Probvaj si kasmeta da otkriesh poleteta bez mini4ki." +
                    " command 'top' pokazva klasiraneto, 'restart' po4va nova igra, 'exit' izliza i hajde 4ao!");

                    PrintGameField(this.gameField);

                    this.flag = false;
                }

                Console.Write("Daj red i kolona : ");

                this.command = Console.ReadLine();

                if (this.command.Length >= 3)
                {
                    bool isCorrectRowIntput = int.TryParse(this.command[0].ToString(), out this.selectedRow);
                    bool isCorrectColIntput = int.TryParse(this.command[2].ToString(), out this.selectedCol);

                    bool isWithinTableRow = this.selectedRow <= this.gameField.GetLength(0);
                    bool isWithinTableCol = this.selectedCol <= this.gameField.GetLength(1);

                    if (isCorrectRowIntput && isCorrectColIntput &&
                        isWithinTableRow && isWithinTableCol)
                    {
                        this.command = "turn";
                    }
                }
                switch (this.command)
                {
                    case "top":
                        GetResults(this.playerRankings);
                        break;
                    case "restart":
                        ProceedGameRestart();
                        break;
                    case "exit":
                        Console.WriteLine("4a0, 4a0, 4a0!");
                        break;
                    case "turn":
                        if (this.mines[this.selectedRow, this.selectedCol] != '*')
                        {
                            if (this.mines[this.selectedRow, this.selectedCol] == '-')
                            {
                                ExecutreTurnCommand(this.gameField, this.mines, this.selectedRow, this.selectedCol);
                                this.mineCounter++;
                            }

                            if (maximumPossiblePoints == this.mineCounter)
                            {
                                this.flag2 = true;
                            }
                            else
                            {
                                PrintGameField(this.gameField);
                            }
                        }
                        else
                        {
                            this.isGameOver = true;
                        }
                        break;
                    default:
                        Console.WriteLine("\nGreshka! nevalidna command\n");
                        break;
                }

                if (this.isGameOver)
                {
                    PrintGameField(this.mines);

                    Console.Write("\nHrrrrrr! Umria gerojski s {0} to4ki. " +
                        "Daj si niknejm: ", mineCounter);

                    string playerName = Console.ReadLine();

                    Player player = new Player(playerName, mineCounter);

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

                    this.gameField = CreateGameFiled();
                    mines = PlaceMines();
                    mineCounter = 0;
                    isGameOver = false;
                    flag = true;
                }
                if (flag2)
                {
                    Console.WriteLine("\nBRAVOOOS! Otvri 35 kletki bez kapka kryv.");

                    PrintGameField(mines);

                    Console.WriteLine("Daj si imeto, batka: ");

                    string name = Console.ReadLine();
                    Player playerRank = new Player(name, mineCounter);

                    playerRankings.Add(playerRank);

                    GetResults(playerRankings);

                    this.gameField = CreateGameFiled();
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

        private void ProceedGameRestart()
        {
            this.gameField = CreateGameFiled();
            this.mines = PlaceMines();

            this.isGameOver = false;
            this.flag = false;

            PrintGameField(this.gameField);
        }

        private static void GetResults(List<Player> points)
        {
            Console.WriteLine("\n Results:");
            if (points.Count > 0)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} kutii",
                        i + 1, points[i].Name, points[i].Points);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("prazna klasaciq!\n");
            }
        }

        private static void ExecutreTurnCommand(
            char[,] gameField,
            char[,] mines,
            int selectedRow,
            int selectedCol)
        {
            char bombsCount = GetBombsCount(mines, selectedRow, selectedCol);
            mines[selectedRow, selectedCol] = bombsCount;
            gameField[selectedRow, selectedCol] = bombsCount;
        }

        private static void PrintGameField(char[,] gameField)
        {
            int boardRows = gameField.GetLength(0);
            int boardCols = gameField.GetLength(1);

            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");

            for (int row = 0; row < boardRows; row++)
            {
                Console.Write("{0} | ", row);
                for (int col = 0; col < boardCols; col++)
                {
                    Console.Write(string.Format("{0} ", gameField[row, col]));
                }
                Console.Write("|");
                Console.WriteLine();
            }
            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreateGameFiled()
        {
            int rows = 5;
            int cols = 10;
            char[,] gameField = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    gameField[i, j] = '?';
                }
            }

            return gameField;
        }

        private static char[,] PlaceMines()
        {
            int rows = 5;
            int cols = 10;
            const short mineQuantity = 15;

            char[,] gameField = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    gameField[i, j] = '-';
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

                gameField[col, row - 1] = '*';
            }

            return gameField;
        }

        private static char GetBombsCount(char[,] mines, int selectedRow, int selectedCol)
        {
            int bombCounter = 0;
            int rows = mines.GetLength(0);
            int cols = mines.GetLength(1);

            if (selectedRow - 1 >= 0)
            {
                if (mines[selectedRow - 1, selectedCol] == '*')
                {
                    bombCounter++;
                }
            }

            if (selectedRow + 1 < rows)
            {
                if (mines[selectedRow + 1, selectedCol] == '*')
                {
                    bombCounter++;
                }
            }

            if (selectedCol - 1 >= 0)
            {
                if (mines[selectedRow, selectedCol - 1] == '*')
                {
                    bombCounter++;
                }
            }

            if (selectedCol + 1 < cols)
            {
                if (mines[selectedRow, selectedCol + 1] == '*')
                {
                    bombCounter++;
                }
            }

            if ((selectedRow - 1 >= 0) && (selectedCol - 1 >= 0))
            {
                if (mines[selectedRow - 1, selectedCol - 1] == '*')
                {
                    bombCounter++;
                }
            }

            if ((selectedRow - 1 >= 0) && (selectedCol + 1 < cols))
            {
                if (mines[selectedRow - 1, selectedCol + 1] == '*')
                {
                    bombCounter++;
                }
            }

            if ((selectedRow + 1 < rows) && (selectedCol - 1 >= 0))
            {
                if (mines[selectedRow + 1, selectedCol - 1] == '*')
                {
                    bombCounter++;
                }
            }

            if ((selectedRow + 1 < rows) && (selectedCol + 1 < cols))
            {
                if (mines[selectedRow + 1, selectedCol + 1] == '*')
                {
                    bombCounter++;
                }
            }
            return char.Parse(bombCounter.ToString());
        }
    }
}