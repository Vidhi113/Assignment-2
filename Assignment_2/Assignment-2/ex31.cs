using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class ex31
    {
        static void Main(string[] args)
        {
            //31.
            Console.WriteLine("Enter First Integer :");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter FirsSecond Integer :");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1-Addition");
            Console.WriteLine("2-Substraction");
            Console.WriteLine("3-Multiplication");
            Console.WriteLine("4-Division");
            Console.WriteLine("5-Exit");
            Console.WriteLine("Enter Operation Number : ");
            int cf = Convert.ToInt32(Console.ReadLine());

            switch (cf)
            {
                case 1:
                    Console.WriteLine("A + B = {0}", a + b);
                    break;
                case 2:
                    Console.WriteLine("A - B = {0}", a - b);
                    break;
                case 3:
                    Console.WriteLine("A * B = {0}", a * b);
                    break;
                case 4:
                    Console.WriteLine("A / B = {0}", a / b);
                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine("invalid digit. \nPlease try again ....");
                    break;
            }

        }
    }
}
