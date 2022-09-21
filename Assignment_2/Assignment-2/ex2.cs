using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class ex2
    {
        static void Main(string[] args)
        {
            //2.
            Console.WriteLine("Enter Number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Width : ");
            int width = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < width - i; j++)
                {
                    Console.Write(n + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
