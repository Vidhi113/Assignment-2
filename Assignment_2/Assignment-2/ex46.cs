using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class ex46
    {
        static void Main(string[] args)
        {
            //46.
            Console.WriteLine("Input the number of elements to store in the array :");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number : ");
            int[] a = new int[n];
            int i;
            for (i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Input the Position, where the value to be Deleted :");
            int pos = Convert.ToInt32(Console.ReadLine());
            Console.Write("The current list of the array :");
            for (i = 0; i < n; i++)
                Console.Write("{0} ", a[i]);
            Console.WriteLine();
            i = 0;
            while (i != pos - 1)
                i++;
            while (i < n)
            {
                a[i] = a[i + 1];
                i++;
            }
            n--;
            Console.Write("After Delete the element the new list is :");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine();

        }
    }
}
