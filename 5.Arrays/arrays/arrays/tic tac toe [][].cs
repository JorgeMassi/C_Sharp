﻿using System;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Threading;

namespace arrays
{
    class Tic
    {
        static int player = 2;
        static int input = 0;
        static bool runGame = true;
        static bool inputCorrect = true;

        internal static void PlayXorO()
        {
            while (true)
            {
                PlayGame();
            }
        }

        static char[,] playField =
        {
            {'1', '2', '3' },
            {'4', '5', '6' },
            {'7', '8', '9' }
        };

        public static void SetField()
        {
            Console.WriteLine();
            Console.WriteLine(" tic tac toe bidime");
            Console.WriteLine("      |    |   ");
            Console.WriteLine("  {0}   | {1}  | {2}  ", playField[0, 0], playField[0, 1], playField[0, 2]);
            Console.WriteLine("______|____|______   ");
            Console.WriteLine("      |    |   ");
            Console.WriteLine("  {0}   | {1}  | {2}  ", playField[1, 0], playField[1, 1], playField[1, 2]);
            Console.WriteLine("______|____|______   ");
            Console.WriteLine("      |    |   ");
            Console.WriteLine("  {0}   | {1}  | {2}  ", playField[2, 0], playField[2, 1], playField[2, 2]);
        }

        public static void PlayGame()
        {

            if (player == 2)
            {
                player = 1;
                GetXorO('X', input);
            }
            else if (player == 1)
            {
                player = 2;
                GetXorO('O', input);
            }
            SetField();
            playerChar();
        }
        public static void playerChar()
        {
            char[] playerChar = { 'X', 'O' };

            if (((playField[0, 0] == playerChar) && (playField[0, 1] == playerChar) && (playField[0, 2] == playerChar)) ||
                ((playField[1, 0] == playerChar) && (playField[1, 1] == playerChar) && (playField[1, 2] == playerChar)) ||
                    ((playField[2, 0] == playerChar) && (playField[2, 1] == playerChar) && (playField[2, 2] == playerChar)) ||
                    ((playField[0, 0] == playerChar) && (playField[0, 1] == playerChar) && (playField[0, 2] == playerChar)) ||
                    ((playField[1, 0] == playerChar) && (playField[1, 1] == playerChar) && (playField[1, 2] == playerChar)) ||
                    ((playField[2, 0] == playerChar) && (playField[2, 1] == playerChar) && (playField[2, 2] == playerChar)) ||
                    ((playField[0, 0] == playerChar) && (playField[0, 1] == playerChar) && (playField[0, 2] == playerChar)) ||
                    ((playField[1, 0] == playerChar) && (playField[1, 1] == playerChar) && (playField[1, 2] == playerChar)) ||
                    ((playField[2, 0] == playerChar) && (playField[2, 1] == playerChar) && (playField[2, 2] == playerChar)))
            {

                if (playerChar == 'O')
                {
                    Console.WriteLine("\nPlayer 1 Win!");
                    Console.WriteLine("Press any key to Restart the game");
                    Console.ReadKey();
                    runGame = false;
                }
                else
                {
                    Console.WriteLine("\nPlayer 2 Win!");
                    Console.WriteLine("Press any key to Restart the game");
                    Console.ReadKey();
                    runGame = false;
                }

            }
            if (runGame)
            {

                do
                {
                    Console.WriteLine("\nPlayer {0} choose your field:  ", player);
                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());
                        if ((input == '1') && (playField[0, 0] == '1')) inputCorrect = true;
                        else if ((input == '2') && (playField[0, 1] == '2')) inputCorrect = true;
                        else if ((input == '3') && (playField[0, 2] == '3')) inputCorrect = true;
                        else if ((input == '4') && (playField[1, 0] == '4')) inputCorrect = true;
                        else if ((input == '5') && (playField[1, 1] == '5')) inputCorrect = true;
                        else if ((input == '6') && (playField[1, 2] == '6')) inputCorrect = true;
                        else if ((input == '7') && (playField[2, 0] == '7')) inputCorrect = true;
                        else if ((input == '8') && (playField[2, 1] == '8')) inputCorrect = true;
                        else if ((input == '9') && (playField[2, 2] == '9')) inputCorrect = true;
                        else
                        {
                            if ((input > 0 && input < 10))
                            {
                                Console.WriteLine("\nPlease choose another field");
                                inputCorrect = false;
                            }
                            else
                            {
                                Console.WriteLine("\nPlease choose from 1 to 9");
                                inputCorrect = false;
                            }
                        }
                    }
                    catch
                    {
                        Console.WriteLine("\nPlease input a number");
                    }
                } while (!inputCorrect);
            }
        }while (runGame);
            ResetGame();
    }
    public static void GetXorO(char playerSign, int input)
    {
        switch (input)
        {
            case 1:
                playField[0, 0] = playerSign; break;
            case 2:
                playField[0, 1] = playerSign; break;
            case 3:
                playField[0, 2] = playerSign; break;
            case 4:
                playField[1, 0] = playerSign; break;
            case 5:
                playField[1, 1] = playerSign; break;
            case 6:
                playField[1, 2] = playerSign; break;
            case 7:
                playField[2, 0] = playerSign; break;
            case 8:
                playField[2, 1] = playerSign; break;
            case 9:
                playField[2, 2] = playerSign; break;
        }
    }
    public static void ResetGame()
    {
        char[,] resetPlayField =
        {
                {'1', '2', '3' },
                {'4', '5', '6' },
                {'7', '8', '9' }
            };
        playField = resetPlayField;
        player = 2;
        input = 0;
        runGame = true;
        inputCorrect = true;
    }
}
