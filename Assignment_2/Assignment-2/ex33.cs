using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class ex33
    {
        static void Main(string[] args)
        {
            //33.
            Console.WriteLine("Input ELEMENT in array : ");
            int[] arr = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write("element - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 3; i++)
            {
                Console.Write("{0} ", arr[i]);
            } Console.WriteLine();
            for (int i = 3; i < 0; i--)
            {
                Console.Write("{0} ", arr[i]);
            }

        }
    }
}
