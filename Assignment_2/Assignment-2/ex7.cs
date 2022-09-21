using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class ex7
    {
        static void Main(string[] args)
        {
            //7.
            Console.WriteLine("Input Any Character :");
            char ch = Convert.ToChar(Console.ReadLine());
            if ((ch == 'a') || (ch == 'e') || (ch == 'i') || (ch == 'o') || (ch == 'u'))
            {
                Console.WriteLine("It's a lowercase vowel.");
            }
            else if ((ch >= '0') && (ch <= '9'))
            {
                Console.WriteLine("It's a digit.");
            }
            else
            {
                Console.WriteLine("It's another symbol.");
            }

        }
    }
}
