using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class ex12
    {
        static void Main(string[] args)
        {
            //12.
            Console.WriteLine("Enter Number : ");
            int a = Convert.ToInt16(Console.ReadLine());
            if (a > 0)
            {
                Console.WriteLine("{0} is Positive Number ", a);
            }
            else
            {
                Console.WriteLine("{0} is Negative Number ", a);
            }

        }
    }
}
