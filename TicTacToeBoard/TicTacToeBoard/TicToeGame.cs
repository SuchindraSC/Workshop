using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeBoard
{
    public class TicToeGame
    {
        public static string computer;
        public static char[] board = new char[10];
        public static void tictactoeUC1()
        {
            
            for (int i = 1; i < board.Length; i++)
            {
                board[i] = ' ';
            }
        }
        public static void tictactoeUC2()
        {

            Console.WriteLine("Select 'X' or 'O': ");
            string player = Console.ReadLine();
            if (player.ToUpper() == "X")
            {
                computer = "O";
            }
            else if(player.ToUpper() == "O")
            {
                computer = "X";
            }
            else
            {
                Console.WriteLine("Invalid Input!");
            }
        }
        public static void showBoardUC3()
        {
            Console.WriteLine("     |     |     ");
            Console.WriteLine(" {0} | {1} | {2} ",board[1], board[2], board[3]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine(" {0} | {1} | {2} ", board[4], board[5], board[6]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine(" {0} | {1} | {2} ", board[7], board[8], board[9]);
            Console.WriteLine("     |     |     ");
        }
    }
}
