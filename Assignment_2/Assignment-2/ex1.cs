using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class ex1
    {
        static void Main(string[] args)
        {  
            //1.
            Console.WriteLine("Enter three Character : ");
            char[] c = new char[3];
            int i;
            for (i = 0; i < 3; i++)
            {
                Console.Write("Char[{0}] : ", i);
                c[i] = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine();
            for (i = 2; i >= 0; i--)
            {
                Console.Write("{0} ", c[i]);
            }
            Console.WriteLine();
        }
    }
}
