using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class ex35
    {
        static void Main(string[] args)
        {

            //35.
            Console.WriteLine("Input the number of elements to store in the array :");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number : ");
            int[] a = new int[n];
            int[] b = new int[n];
            int i;
            for (i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
                b[i] = a[i];
            }
            Console.Write("The elements stored in the first array are : ");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", a[i]);
            } Console.WriteLine();
            Console.Write("The elements copied into the second array are : ");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", b[i]);
            } Console.WriteLine();

        }
    }
}
