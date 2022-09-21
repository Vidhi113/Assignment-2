using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class ex47
    {
        static void Main(string[] args)
        {
            //47.
            Console.WriteLine("Input the number of elements to store in the array :");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number : ");
            int[] a = new int[n];
            int i, j = 0, max2, max = 0;
            for (i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            max = 0;

            for (i = 0; i < n; i++)
            {
                if (max < a[i])
                {
                    max = a[i];
                    j = i;
                }
            }
            max2 = 0;
            for (i = 0; i < n; i++)
            {
                if (i == j)
                {
                    i++;
                    i--;
                }
                else
                {
                    if (max2 < a[i])
                    {
                        max2 = a[i];
                    }
                }
            }
            Console.WriteLine("The Second largest element in the array is: {0}", max2);

        }
    }
}
