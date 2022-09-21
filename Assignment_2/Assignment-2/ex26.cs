using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class ex26
    {
        static void Main(string[] args)
        {
            //26.
            Console.WriteLine("Enter Grade Character : ");
            char grade = Convert.ToChar(Console.ReadLine());
            switch (grade)
            {
                case 'e':
                    Console.WriteLine("you have chosen : Excellent");
                    break;
                case 'v':
                    Console.WriteLine("you have chosen : Excellent");
                    break;
                case 'g':
                    Console.WriteLine("you have chosen : Excellent");
                    break;
                case 'a':
                    Console.WriteLine("you have chosen : Excellent");
                    break;
                case 'f':
                    Console.WriteLine("you have chosen : Excellent");
                    break;
                default:
                    Console.WriteLine("Plese enter valid grade");
                    break;
            }

        }
    }
}
