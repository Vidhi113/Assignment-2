using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class ex22
    {
        static void Main(string[] args)
        {
            //22.
            Console.WriteLine("Enter Side of triange     : ");
            int[] side = new int[3];
            int sum = 0, i;
            for (i = 0; i < 3; i++)
            {
                side[i] = Convert.ToInt16(Console.ReadLine());
                sum += side[i];
            }
            if (sum == 180)
            {
                Console.WriteLine("The triangle is valid.");
            }
            else { Console.WriteLine("The triangle is not valid."); }

        }
    }
}
