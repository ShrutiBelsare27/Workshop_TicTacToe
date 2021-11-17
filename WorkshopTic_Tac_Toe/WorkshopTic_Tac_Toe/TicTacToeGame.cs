using System;
using System.Collections.Generic;
using System.Text;

namespace WorkshopTic_Tac_Toe
{
    public class TicTacToeGame
    {
      
        char[] arr = new char[10];
        public void Board()
        {
            for (int i = 0; i <= 9; i++)
            {
            
                //Console.WriteLine(arr[i]);
                arr[i] = ' ';
            }
        }
    }
}
