using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class ex54
    {
        static void Main(string[] args)
        {
            //54.
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
            Console.WriteLine("The sum or rows and columns of the matrix is : ");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    sum = sum += a[i, j];
                    Console.Write("{0}   ", a[i, j]);
                }
                Console.Write("{0}  ", sum);
                sum = 0;
                Console.WriteLine();
            }
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    sum = sum += a[j, i];
                }
                Console.Write("{0}  ", sum);
                sum = 0;
            }
            Console.WriteLine();

        }
    }
}
