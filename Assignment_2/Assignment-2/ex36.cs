using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class ex36
    {
        static void Main(string[] args)
        {
            //36.
            Console.WriteLine("Input the number of elements to store in the array :");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number : ");
            int[] arr1 = new int[n];
            int[] arr2 = new int[n];
            int[] arr3 = new int[n];
            int mm = 1, ctr = 0;
            int i, j;
            for (i = 0; i < n; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < n; i++)
            {
                arr2[i] = arr1[i];
                arr3[i] = 0;
            }
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        arr3[j] = mm;
                        mm++;
                    }
                }
                mm = 1;
            }
            for (i = 0; i < n; i++)
            {
                if (arr3[i] == 2) { ctr++; }
            }
            Console.WriteLine("The number of duplicate elements is: {0} ", ctr);
            Console.WriteLine();

        }
    }
}
