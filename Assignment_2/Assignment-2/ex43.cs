using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class ex43
    {
        static void Main(string[] args)
        {
            //43.
            Console.WriteLine("Input the number of elements to store in the array :");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number : ");
            int[] a = new int[n];
            int i, j, temp = 0;
            for (i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < n; i++)
            {
                for (j = i; j < n; j++)
                {
                    if (a[j] > a[i])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            Console.Write("Elements of array in sorted descending order: ");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0} ", a[i]);
            } Console.WriteLine();

        }
    }
}
