using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class ex15
    {
        static void Main(string[] args)
        {
            //15.
            Console.WriteLine("Enter The Value of m : ");
            int a = Convert.ToInt16(Console.ReadLine());
            if (a > 0)
            {
                Console.WriteLine("The value of n = 1");
            }
            else if (a == 0)
            {
                Console.WriteLine("The value of n = 0");
            }
            else
            {
                Console.WriteLine("The value of n = -1");
            }

        }
    }
}
