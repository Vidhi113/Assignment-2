using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class ex17
    {
        static void Main(string[] args)
        {
            //17.
            Console.WriteLine("Enter First Number : ");
            int a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Second Number : ");
            int b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Second Number : ");
            int c = Convert.ToInt16(Console.ReadLine());
            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("{0} is Largest of three ", a);
                }
                else
                {
                    Console.WriteLine("{0} is Largest of three ", c);
                }
            }
            else
            {
                if (b > c)
                {
                    Console.WriteLine("{0} is Largest of three ", b);
                }
                else
                {
                    Console.WriteLine("{0} is Largest of three ", c);
                }
            }

        }
    }
}
