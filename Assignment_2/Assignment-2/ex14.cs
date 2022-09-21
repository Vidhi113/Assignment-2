using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class ex14
    {
        static void Main(string[] args)
        {
            //14.
            Console.WriteLine("Enter Your Age : ");
            int age = Convert.ToInt16(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("Congratulation! You are eligible for casting your vote.");
            }
            else
            {
                Console.WriteLine("You Not are eligible");
            }

        }
    }
}
