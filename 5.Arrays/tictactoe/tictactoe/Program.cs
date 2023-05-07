using System;

namespace tictactoe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char player = 'X';
            char[,] board = new char[3, 3];
            bool valid = true;
            inicialBoard(board);
            int movesDraw = 0;

         

            while (true)
            {
                Console.Clear();
                Print(board);

                Console.Write(" please enter row: ");
                int row = Convert.ToInt32(Console.ReadLine());
                Console.Write("please enter col: ");
                int col = Convert.ToInt32(Console.ReadLine());



                if (board[row,col] == ' ')
                {
                    board[row, col] = player;
                    movesDraw = movesDraw + 1;
                    player = Player(player);
                }
                else
                {
                    Console.WriteLine(" choose another");
                    Console.ReadKey();
                }

                if(player == board[0, 0] && player == board[0,1] && player == board[0,2] || 
                    player == board[1, 0] && player == board[1, 1] && player == board[1, 2] || 
                    player == board[2, 0] && player == board[2, 1] && player == board[2, 2])
                {
                    Console.WriteLine("player " + player + " win" );
                    break;
                }
                else if (player == board[0, 0] && player == board[1, 0] && player == board[2, 0] ||
                    player == board[1, 0] && player == board[1, 1] && player == board[1, 2] ||
                    player == board[2, 0] && player == board[1, 1] && player == board[2, 2])
                {
                    Console.WriteLine("player " + player + " win");
                    break;
                }
                else if (player == board[0, 0] && player == board[1, 1] && player == board[2, 2] ||
                    player == board[2, 0] && player == board[1, 1] && player == board[0, 2])
                {
                    Console.WriteLine("player " + player + " win");
                    break;
                }


                if (movesDraw == 9)
                {
                    Console.WriteLine(" draw");
                    break;
                }

            }
        }
        static void inicialBoard(char[,] board)
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    board[row, col] = ' ';
                }
            }


        }
        static void Print(char[,] board)
        {
            Console.WriteLine("  | 0 | 1 | 2 |");
            for (int row = 0; row < 3; row++)
            {
                Console.Write(row +" | ");
               
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(board[row, col]);
                    Console.Write(" | ");
                }
                Console.WriteLine();
            }
        }
        static char Player(char currentPlayer)
        {
                if (currentPlayer == 'X')
                {
                    return  'O';   
                }
                else
                {
                    return 'X';
                }
        }

        
  
    }
}
