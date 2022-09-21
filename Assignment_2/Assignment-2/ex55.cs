using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class ex55
    {
        static void Main(string[] args)
        {
            //55.
            Console.Write("Input the size of the square matrix (less than 5) : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Value for First Matrix : ");
            int[,] a = new int[n, n];
            int i, j, count = 0;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("element - [{0}] , [{1}] : ", i, j);
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }
            Console.WriteLine("Enter Value for Second Matrix : ");
            int[,] b = new int[n, n];
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("element - [{0}] , [{1}] : ", i, j);
                    b[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }
            Console.WriteLine("The First matrix is : ");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("{0} ", a[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("The Second matrix is : ");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("{0} ", b[i, j]);
                }
                Console.WriteLine();
            }
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    if (a[i, j] == b[i, j])
                    {
                        count++;
                    }
                }
                Console.WriteLine();
            }
            if (count == n * n)
            {
                Console.WriteLine("The Matrices can be compared : \nTwo matrices are equal.");
            }
            else
            {
                Console.WriteLine("The Matrices cann't be compared : \nTwo matrices are not equal.");
            }
        }
    }
}
