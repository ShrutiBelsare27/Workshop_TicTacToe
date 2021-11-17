using System;
using System.Collections.Generic;
using System.Text;

namespace WorkshopTic_Tac_Toe
{
   public  class ShowBoard
    {
        char[] arr = new char[10];
        public void showBoard()
        {
            Console.WriteLine(" {0} | {1} | {2}", arr[1],arr[2],arr[3]);
            Console.WriteLine("______________");
            Console.WriteLine(" {0} | {1} | {2}", arr[4], arr[5], arr[6]);
            Console.WriteLine("______________");
            Console.WriteLine(" {0} | {1} | {2}", arr[7], arr[8], arr[0]);
        
        }
    }
}
