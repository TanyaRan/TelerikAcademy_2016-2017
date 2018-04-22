using System;
using System.Collections.Generic;

namespace MinesweeperGame
{
    public class StartupMinesweeper
    {
        public static void Main()
        {
            string command = string.Empty;
            char[,] gameField = CreateGameField();
            char[,] mines = SetMines();
            int counter = 0;
            bool isMine = false;
            List<Ranking> champions = new List<Ranking>(6);
            int row = 0;
            int column = 0;
            bool inGame = true;
            const int max = 35;
            bool hasMaxResult = false;

            do
            {
                if (inGame)
                {
                    Console.WriteLine("Lets play MineSweeper. Try to find the free from mines fields." +
                        "The 'top' command shows the current standings, 'restart' starts a new game, 'exit'" +
                        "quits the game.");
                    PrintField(gameField);
                    inGame = false;
                }

                Console.Write("Enter row and column: ");
                command = Console.ReadLine().Trim();

                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) && int.TryParse(command[2].ToString(), out column)
                        && row <= gameField.GetLength(0) && column <= gameField.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        GetRanking(champions);
                        break;
                    case "restart":
                        gameField = CreateGameField();
                        mines = SetMines();
                        PrintField(gameField);
                        break;
                    case "exit":
                        Console.WriteLine("Bye, bye, bye!");
                        break;
                    case "turn":
                        if (mines[row, column] != '*')
                        {
                            if (mines[row, column] == '-')
                            {
                                ChangeTurn(gameField, mines, row, column);
                                counter++;
                            }

                            if (max == counter)
                            {
                                hasMaxResult = true;
                            }
                            else
                            {
                                PrintField(gameField);
                            }
                        }
                        else
                        {
                            isMine = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nError! Invalid command!\n");
                        break;
                }

                if (isMine)
                {
                    PrintField(mines);
                    Console.Write("\nBOOM! You died heroically with {0} points. Enter your nickname: ", counter);
                    string nickName = Console.ReadLine();
                    Ranking tempResult = new Ranking(nickName, counter);
                    if (champions.Count < 5)
                    {
                        champions.Add(tempResult);
                    }
                    else
                    {
                        for (int i = 0; i < champions.Count; i++)
                        {
                            if (champions[i].Points < tempResult.Points)
                            {
                                champions.Insert(i, tempResult);
                                champions.RemoveAt(champions.Count - 1);
                                break;
                            }
                        }
                    }

                    champions.Sort((Ranking r1, Ranking r2) => r2.Name.CompareTo(r1.Name));
                    champions.Sort((Ranking r1, Ranking r2) => r2.Points.CompareTo(r1.Points));
                    GetRanking(champions);

                    gameField = CreateGameField();
                    mines = SetMines();
                    counter = 0;
                    isMine = false;
                    inGame = true;
                }

                if (hasMaxResult)
                {
                    Console.WriteLine("\nCongratulations! You opened 35 cells!");
                    PrintField(mines);
                    Console.WriteLine("Enter your name, please: ");
                    string name = Console.ReadLine();
                    Ranking points = new Ranking(name, counter);
                    champions.Add(points);
                    GetRanking(champions);
                    gameField = CreateGameField();
                    mines = SetMines();
                    counter = 0;
                    hasMaxResult = false;
                    inGame = true;
                }
            }
            while (command != "exit");

            Console.WriteLine("Made in Bulgaria");
            Console.Read();
        }

        private static void GetRanking(List<Ranking> points)
        {
            Console.WriteLine("\nPoints: ");
            if (points.Count > 0)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} cells",
                            i + 1, points[i].Name, points[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("No points!\n");
            }
        }

        private static void ChangeTurn(char[,] field, char[,] mines, int row, int column)
        {
            char numberOfMines = CountMines(mines, row, column);
            mines[row, column] = numberOfMines;
            field[row, column] = numberOfMines;
        }

        private static void PrintField(char[,] board)
        {
            int boardRows = board.GetLength(0);
            int boardColumns = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < boardRows; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < boardColumns; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreateGameField()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] SetMines()
        {
            int rows = 5;
            int colomuns = 10;
            char[,] gameField = new char[rows, colomuns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colomuns; j++)
                {
                    gameField[i, j] = '-';
                }
            }

            List<int> mines = new List<int>();
            while (mines.Count < 15)
            {
                Random random = new Random();
                int newMine = random.Next(50);
                if (!mines.Contains(newMine))
                {
                    mines.Add(newMine);
                }
            }

            foreach (int mine in mines)
            {
                int column = mine / colomuns;
                int row = mine % colomuns;
                if (row == 0 && mine != 0)
                {
                    column--;
                    row = colomuns;
                }
                else
                {
                    row++;
                }

                gameField[column, row - 1] = '*';
            }

            return gameField;
        }

        private static void Calculate(char[,] field)
        {
            int column = field.GetLength(0);
            int row = field.GetLength(1);

            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (field[i, j] != '*')
                    {
                        char count = CountMines(field, i, j);
                        field[i, j] = count;
                    }
                }
            }
        }

        private static char CountMines(char[,] field, int currentRow, int currentColumn)
        {
            int mineCounter = 0;
            int rows = field.GetLength(0);
            int columns = field.GetLength(1);

            if (currentRow - 1 >= 0)
            {
                if (field[currentRow - 1, currentColumn] == '*')
                {
                    mineCounter++;
                }
            }

            if (currentRow + 1 < rows)
            {
                if (field[currentRow + 1, currentColumn] == '*')
                {
                    mineCounter++;
                }
            }

            if (currentColumn - 1 >= 0)
            {
                if (field[currentRow, currentColumn - 1] == '*')
                {
                    mineCounter++;
                }
            }

            if (currentColumn + 1 < columns)
            {
                if (field[currentRow, currentColumn + 1] == '*')
                {
                    mineCounter++;
                }
            }

            if ((currentRow - 1 >= 0) && (currentColumn - 1 >= 0))
            {
                if (field[currentRow - 1, currentColumn - 1] == '*')
                {
                    mineCounter++;
                }
            }

            if ((currentRow - 1 >= 0) && (currentColumn + 1 < columns))
            {
                if (field[currentRow - 1, currentColumn + 1] == '*')
                {
                    mineCounter++;
                }
            }

            if ((currentRow + 1 < rows) && (currentColumn - 1 >= 0))
            {
                if (field[currentRow + 1, currentColumn - 1] == '*')
                {
                    mineCounter++;
                }
            }

            if ((currentRow + 1 < rows) && (currentColumn + 1 < columns))
            {
                if (field[currentRow + 1, currentColumn + 1] == '*')
                {
                    mineCounter++;
                }
            }

            return char.Parse(mineCounter.ToString());
        }
    }
}
