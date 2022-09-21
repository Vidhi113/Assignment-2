using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class ex30
    {
        static void Main(string[] args)
        {
            //30.
            int cdigit;
            Console.WriteLine("Accept digit and display in month days:");
            Console.WriteLine("Input Digit(0-12) : ");
            cdigit = Convert.ToInt32(Console.ReadLine());

            switch (cdigit)
            {
                case 1:
                    Console.WriteLine("31");
                    break;
                case 2:
                    Console.WriteLine("28/29");
                    break;
                case 3:
                    Console.WriteLine("31");
                    break;
                case 4:
                    Console.WriteLine("30");
                    break;
                case 5:
                    Console.WriteLine("31");
                    break;
                case 6:
                    Console.WriteLine("30");
                    break;
                case 7:
                    Console.WriteLine("31");
                    break;
                case 8:
                    Console.WriteLine("31");
                    break;
                case 9:
                    Console.WriteLine("30");
                    break;
                case 10:
                    Console.WriteLine("31");
                    break;
                case 11:
                    Console.WriteLine("30");
                    break;
                case 12:
                    Console.WriteLine("31");
                    break;
                default:
                    Console.WriteLine("invalid digit. \nPlease try again ....");
                    break;
            }

        }
    }
}
