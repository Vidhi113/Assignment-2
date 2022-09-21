using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class ex39
    {
        static void Main(string[] args)
        {
            //39.
            Console.WriteLine("Input the number of elements to store in the array :");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number : ");
            int[] a = new int[n];
            int i, j;
            for (i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            int count = 0;
            for (i = 0; i < n; i++)
            {
                for (j = i; j < n; j++)
                {
                    if (a[i] == a[j])
                    {
                        count++;
                    }
                }
                Console.WriteLine("{0} occurs {1} times", a[i], count);
                count--;
            }
        }
    }
}
