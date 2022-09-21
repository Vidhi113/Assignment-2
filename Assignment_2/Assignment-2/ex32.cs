using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class ex32
    {
        static void Main(string[] args)
        {
            //32.
            Console.WriteLine("Input 10 ELEMENT in array : ");
            int[] arr = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("element - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0} ", arr[i]);
            }

        }
    }
}
