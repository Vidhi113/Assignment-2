using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class ex9
    {
        static void Main(string[] args)
        {
            //9.
            Console.WriteLine("Enter Decimal Numbere : ");
            int n = Convert.ToInt16(Console.ReadLine());
            int i;
            int[] a = new int[10];
            for (i = 0; n > 0; i++)
            {
                a[i] = n % 2;
                n /= 2;
            }
            Console.Write("Binary of {0} = ", n);
            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(a[i]);
            }
            Console.WriteLine();

        }
    }
}
