using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class ex27
    {
        static void Main(string[] args)
        {
            //27.
            int dayno;
            Console.WriteLine("Accept day number and display its equivalent day name in word:");
            Console.WriteLine("Input Day No : ");
            dayno = Convert.ToInt32(Console.ReadLine());

            switch (dayno)
            {
                case 1:
                    Console.WriteLine("Monday ");
                    break;
                case 2:
                    Console.WriteLine("Tuesday ");
                    break;
                case 3:
                    Console.WriteLine("Wednesday ");
                    break;
                case 4:
                    Console.WriteLine("Thursday ");
                    break;
                case 5:
                    Console.WriteLine("Friday ");
                    break;
                case 6:
                    Console.WriteLine("Saturday ");
                    break;
                case 7:
                    Console.WriteLine("Sunday ");
                    break;
                default:
                    Console.WriteLine("Invalid day number. \nPlease try again ....");
                    break;
            }

        }
    }
}
