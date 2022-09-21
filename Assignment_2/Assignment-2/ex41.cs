using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class ex41
    {
        static void Main(string[] args)
        {
            //41.
            Console.WriteLine("Input the number of elements to store in the array :");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number : ");
            int[] a = new int[n];
            int i;
            for (i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Even Elements : ");
            for (i = 0; i < n; i++)
            {
                if (a[i] % 2 == 0)
                {
                    Console.Write("{0} ", a[i]);
                }
            }
            Console.WriteLine();
            Console.Write("Odd Elements : ");
            for (i = 0; i < n; i++)
            {
                if (a[i] % 2 != 0)
                {
                    Console.Write("{0} ", a[i]);
                }
            } Console.WriteLine();

        }
    }
}
