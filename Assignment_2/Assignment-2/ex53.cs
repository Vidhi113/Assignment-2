using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class ex53
    {
        static void Main(string[] args)
        {
            //53.
            Console.Write("Input the size of the square matrix (less than 5) : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Value for Matrix : ");
            int[,] a = new int[n, n];
            int i, j, sum = 0, m = n;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("element - [{0}] , [{1}] : ", i, j);
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }
            Console.WriteLine("The matrix is : ");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("{0} ", a[i, j]);
                }
                Console.WriteLine();
            }
            for (i = 0; i < n; i++)
            {
                m = m - 1;
                for (j = 0; j < n; j++)
                {
                    if (m == j)
                    {
                        sum += sum + a[i, j];
                    }
                }
            }
            Console.WriteLine("Addition of the left Diagonal elements is : {0} ", sum);

        }
    }
}
