using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class ex8
    {
        static void Main(string[] args)
        {
            //8.
            Console.WriteLine("Enter First NUmber : ");
            int a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Second NUmber : ");
            int b = Convert.ToInt16(Console.ReadLine());
            if (a % 2 == 0 && b % 2 == 0 || a % 2 != 0 && a % 2 != 0)
            {
                Console.WriteLine(true);
            }
            else { Console.WriteLine(false); }

        }
    }
}
