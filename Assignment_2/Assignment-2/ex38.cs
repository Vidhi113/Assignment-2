using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class ex38
    {
        static void Main(string[] args)
        {
            //38.
            Console.WriteLine("Input the number of elements to store in the array :");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number : ");
            int[] a = new int[n1];
            int i;
            for (i = 0; i < n1; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Input the number of elements to store in the array :");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number : ");
            int[] b = new int[n2];
            for (i = 0; i < n2; i++)
            {
                b[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < n2; i++)
            {
                Console.Write("{0} {1}  ", a[i], b[i]);
            }

        }
    }
}
