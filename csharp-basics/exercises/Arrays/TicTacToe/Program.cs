using System;

namespace TicTacToe
{
    class Program
    {
        private static char[,] _board = new char[3, 3];
        static char currentPlayer = 'X';

        public static bool isEmpty(int i,int j)
        {
            return _board[i, j] == ' ';
        }

        private static void Main(string[] args)
        {
            InitBoard();
            Console.WriteLine("(...a game already in progress)");
            while (true)
            {
                DisplayBoard();
                Console.WriteLine($"{currentPlayer},choose row and column");
                Console.WriteLine("Enter row:");
                string inputRow = Console.ReadLine();
                Console.WriteLine("Enter column:");
                string inputColumn = Console.ReadLine();
                int i, j;
                
                if(int.TryParse(inputRow,out i)&&int.TryParse(inputColumn,out j) && i>=0 && i<3 && j>=0 && j<3 && isEmpty(i, j)){
                    _board[i, j] = currentPlayer;
                    SwapPlayers();
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Invalid value\n");
                }

                string result = CheckForWinner();

                if(result!="Game continue")
                {
                    Console.WriteLine(result);
                    return;
                }
            }
           
        }

        static void SwapPlayers()
        {
            currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
        }

        static string CheckForWinner()
        {
            bool isFull = true;

            bool HorizontalCrossWinn = _board[0, 0] == 'X' && _board[0, 1] == 'X' && _board[0, 2] == 'X' ||
                                       _board[1, 0] == 'X' && _board[1, 1] == 'X' && _board[1, 2] == 'X' ||
                                       _board[2, 0] == 'X' && _board[2, 1] == 'X' && _board[2, 2] == 'X';

            bool VerticalCrossWin = _board[0, 0] == 'X' && _board[1, 0] == 'X' && _board[2, 0] == 'X' ||
                                    _board[0, 1] == 'X' && _board[1, 1] == 'X' && _board[2, 1] == 'X' ||
                                    _board[0, 2] == 'X' && _board[1, 2] == 'X' && _board[2, 2] == 'X';

            bool DiagonaleCrossWin = _board[0, 0] == 'X' && _board[1, 1] == 'X' && _board[2, 2] == 'X' ||
                                     _board[0, 2] == 'X' && _board[1, 1] == 'X' && _board[2, 0] == 'X';


            bool HorizontalOsWinn = _board[0, 0] == 'O' && _board[0, 1] == 'O' && _board[0, 2] == 'O' ||
                                       _board[1, 0] == 'O' && _board[1, 1] == 'O' && _board[1, 2] == 'O' ||
                                       _board[2, 0] == 'O' && _board[2, 1] == 'O' && _board[2, 2] == 'O';

            bool VerticalOsWin = _board[0, 0] == 'O' && _board[1, 0] == 'O' && _board[2, 0] == 'O' ||
                                    _board[0, 1] == 'O' && _board[1, 1] == 'O' && _board[2, 1] == 'O' ||
                                    _board[0, 2] == 'O' && _board[1, 2] == 'O' && _board[2, 2] == 'O';

            bool DiagonaleOsWin = _board[0, 0] == 'O' && _board[1, 1] == 'O' && _board[2, 2] == 'O' ||
                                     _board[0, 2] == 'O' && _board[1, 1] == 'O' && _board[2, 0] == 'O';

            if (HorizontalCrossWinn || VerticalCrossWin || DiagonaleCrossWin)
            {
                return "Cross Win!";
            }

            if (HorizontalOsWinn || VerticalOsWin || DiagonaleOsWin)
            {
                return "O Win!";
            }

            for (int i = 0; i < _board.GetLength(0); i++)
            {
                for(int j = 0; j < _board.GetLength(1); j++)
                {
                    if (isEmpty(i, j))
                    {
                        isFull = false;
                        break;
                    }
                }
            }

            if (isFull)
            {
                return "The game ends with tie";
            }

            return "Game continue";
        }

        private static void InitBoard()
        {
            for (var r = 0; r < 3; r++)
            {
                for (var c = 0; c < 3; c++)
                    _board[r, c] = ' ';
            }

        }

        private static void DisplayBoard()
        {
            Console.WriteLine("  0  " + _board[0, 0] + "|" + _board[0, 1] + "|" + _board[0, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  1  " + _board[1, 0] + "|" + _board[1, 1] + "|" + _board[1, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  2  " + _board[2, 0] + "|" + _board[2, 1] + "|" + _board[2, 2]);
            Console.WriteLine("    --+-+--");
        }
    }
}
