using System;
using System.Collections.Generic;
using System.Text;

namespace WorkshopTic_Tac_Toe
{
    public class ChooseUserLetter
    {
       
        public void chooseUserLetter()
        { 
            Console.WriteLine("Choose the letter X otherwise O ");
            string letter = Console.ReadLine();
            if (letter == "X")
            {
                Console.WriteLine("Use X letter");
           
            }
            else
            {
                Console.WriteLine("Use O letter");
            }
        }
       
    }
}
