using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class ex44
    {
        static void Main(string[] args)
        {
            //44.
            Console.WriteLine("Input the number of elements to store in the array :");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number : ");
            int[] a = new int[n];
            int i, p=0;
            for (i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Input the value to be inserted :");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("The exist array list is :");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0} ", a[i]);
            }
            for (i = 0; i < n; i++)
            {
                if (b < a[i])
                {
                    p = i;
                    break;
                }
                else
                {
                    p = i + 1;
                }
            }
            for (i = n + 1; i >= p; i--)
            {
                a[i] = a[i - 1];
                a[p] = b;
            }
            Console.Write("After Insert the list is : ");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0} ", a[i]);
            }

        }
    }
}
