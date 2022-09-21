using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class ex40
    {
        static void Main(string[] args)
        {
            //40.
            Console.WriteLine("Input the number of elements to store in the array :");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number : ");
            int[] a = new int[n];
            int i, j, min, max = 0;
            for (i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            min = a[0];
            for (j = 1; j < n; j++)
            {
                if (min > a[j])
                {
                    max = min;
                    min = a[j];
                }
                else { max = a[j]; }
            }
            Console.WriteLine("Minumum Element of the array is : {0}", min);
            Console.WriteLine("Maximum Element of the array is : {0}", max);

        }
    }
}
