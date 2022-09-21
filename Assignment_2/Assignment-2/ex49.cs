using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class ex49
    {
        static void Main(string[] args)
        {
            //49.
            Console.WriteLine("Enter Value for Matrix of 3 * 3 : ");
            int[,] a = new int[3, 3];
            int i, j;
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write("element - [{0}] , [{1}] : ", i, j);
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write("{0} ", a[i, j]);
                }
                Console.WriteLine();
            }

        }
    }
}
