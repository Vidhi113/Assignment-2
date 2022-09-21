using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class ex10
    {
        static void Main(string[] args)
        {
            //10.
            Console.WriteLine("Enter First Number : ");
            int a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Second Number : ");
            int b = Convert.ToInt16(Console.ReadLine());
            if (a == b)
            {
                Console.WriteLine("{0} and {1} is equal ", a, b);
            }
            else
            {
                Console.WriteLine("{0} and {1} is not equal ", a, b);
            }

        }
    }
}
