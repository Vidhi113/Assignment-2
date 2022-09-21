using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class ex29
    {
        static void Main(string[] args)
        {
            //29.
            int cdigit;
            Console.WriteLine("Accept digit and display in word:");
            Console.Write("Input Digit(0-12) : ");
            cdigit = Convert.ToInt32(Console.ReadLine());

            switch (cdigit)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("february");
                    break;
                case 3:
                    Console.WriteLine("march");
                    break;
                case 4:
                    Console.WriteLine("april");
                    break;
                case 5:
                    Console.WriteLine("may");
                    break;
                case 6:
                    Console.WriteLine("june");
                    break;
                case 7:
                    Console.WriteLine("july");
                    break;
                case 8:
                    Console.WriteLine("august");
                    break;
                case 9:
                    Console.WriteLine("september");
                    break;
                case 10:
                    Console.WriteLine("october");
                    break;
                case 11:
                    Console.WriteLine("november");
                    break;
                case 12:
                    Console.WriteLine("december");
                    break;
                default:
                    Console.WriteLine("invalid digit. \nPlease try again ....");
                    break;
            }

        }
    }
}