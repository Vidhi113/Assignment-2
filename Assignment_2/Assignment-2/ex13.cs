using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class ex13
    {
        static void Main(string[] args)
        {
            //13.
            Console.WriteLine("Enter Year : ");
            int year = Convert.ToInt16(Console.ReadLine());
            if (year % 4 == 0)
            {
                Console.WriteLine("The year {0} is leap year", year);
            }
            else
            {
                Console.WriteLine("The year {0} is Not leap year", year);
            }

        }
    }
}
