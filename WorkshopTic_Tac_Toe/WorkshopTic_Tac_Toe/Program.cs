﻿using System;

namespace WorkshopTic_Tac_Toe
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to tictactoe");
            TicTacToeGame uc1 = new TicTacToeGame();
            uc1.Board();
        }
    }
}
