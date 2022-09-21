using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class ex45
    {
        static void Main(string[] args)
        {
            //45.
            Console.WriteLine("Input the number of elements to store in the array :");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number : ");
            int[] a = new int[n + 1];
            int i;
            for (i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Input the value to be inserted :");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the Position, where the value to be inserted :");
            int pos = Convert.ToInt32(Console.ReadLine());
            Console.Write("The current list of the array :");
            for (i = 0; i < n; i++)
                Console.Write("{0} ", a[i]);
            Console.WriteLine();
            for (i = n; i >= pos; i--)
            {
                a[i] = a[i - 1];
            }
            a[pos - 1] = b;
            Console.Write("After Insert the element the new list is :");
            for (i = 0; i < n + 1; i++)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine();

        }
    }
}
