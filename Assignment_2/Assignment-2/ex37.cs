using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class ex37
    {
        static void Main(string[] args)
        {
            //37.
            Console.WriteLine("Input the number of elements to be stored in the array :");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr1 = new int[n];
            int ctr = 0, i, j, k;
            Console.WriteLine("Input {0} elements in the array :", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The unique elements found in the array are : ");
            for (i = 0; i < n; i++)
            {
                ctr = 0;
                for (j = 0; j < i - 1; j++)
                {
                    if (arr1[i] == arr1[j])
                    {
                        ctr++;
                    }
                }
                for (k = i + 1; k < n; k++)
                {
                    if (arr1[i] == arr1[k])
                    {
                        ctr++;
                    }
                    if (arr1[i] == arr1[i + 1])
                    {
                        i++;
                    }
                }
                if (ctr == 0)
                {
                    Console.Write("{0} ", arr1[i]);
                }
            }
            Console.WriteLine();

        }
    }
}
