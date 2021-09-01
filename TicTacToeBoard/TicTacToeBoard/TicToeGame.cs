using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeBoard
{
    public class TicToeGame
    {
        public static string computer;
        public static void tictactoeUC1()
        {
            char[] board = new char[10];
            for (int i = 0; i <= board.Length; i++)
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
            Console.WriteLine("    |    |    ");
            Console.WriteLine("____|____|____");
            Console.WriteLine("    |    |    ");
            Console.WriteLine("____|____|____");
            Console.WriteLine("    |    |    ");
            Console.WriteLine("    |    |    ");
        }
    }
}
