using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class ex48
    {
        static void Main(string[] args)
        {
            //48.
            Console.WriteLine("Input the number of elements to store in the array :");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number : ");
            int[] a = new int[n];
            int i, j = 0, min2, min;
            for (i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            min = 0;

            for (i = 0; i < n; i++)
            {
                if (min > a[i])
                {
                    min = a[i];
                    j = i;
                }
            }
            min2 = 9999;
            for (i = 0; i < n; i++)
            {
                if (i == j)
                {
                    i++;
                    i--;
                }
                else
                {
                    if (min2 > a[i])
                    {
                        min2 = a[i];
                    }
                }
            }
            Console.WriteLine("The Second Smallest element in the array is: {0}", min2);

        }
    }
}
