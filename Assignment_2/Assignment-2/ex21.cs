using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class ex21
    {
        static void Main(string[] args)
        {
            //21.
            Console.WriteLine("Enter Side of Triangle : ");
            int[] side = new int[3];
            for (int i = 0; i < 2; i++)
            {
                side[i] = Convert.ToInt16(Console.ReadLine());
            }
            side[2] = 180 - side[0] - side[1];
            Console.WriteLine(side[2]);
            if (side[0] == side[1] && side[1] == side[2])
            {
                Console.WriteLine("Triangle is Equilateral");
            }
            else if (side[0] == side[1] || side[1] == side[2] || side[2] == side[0])
            {
                Console.WriteLine("Triangle is Isosceles");
            }
            else { Console.WriteLine("Triangle is Scalene"); }

        }
    }
}
