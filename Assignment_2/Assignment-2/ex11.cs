using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class ex11
    {
        static void Main(string[] args)
        {
            //11.
            Console.WriteLine("Enter Number : ");
            int a = Convert.ToInt16(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("{0} is Odd Number ", a);
            }
            else
            {
                Console.WriteLine("{0} is Even Number ", a);
            }

        }
    }
}
