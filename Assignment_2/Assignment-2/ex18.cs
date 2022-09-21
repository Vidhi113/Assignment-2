using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class ex18
    {
        static void Main(string[] args)
        {
            //18.
            Console.WriteLine("Enter Your Marks of Maths     : ");
            int m = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Your Marks of Pysics    : ");
            int f = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Your Marks of Chemestry : ");
            int c = Convert.ToInt16(Console.ReadLine());
            int sum = m + f + c;
            if (m >= 65 && f >= 55 && c >= 50 && sum >= 180)
            {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else
            {
                Console.WriteLine("The candidate is not eligible for admission.");
            }

        }
    }
}
