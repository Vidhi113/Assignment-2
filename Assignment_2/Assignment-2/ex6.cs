using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class ex6
    {
        static void Main(string[] args)
        {
            //6.
            double Pi = 3.14;
            Console.WriteLine("Input The Radius Of The Sphere :");
            int redius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Surface of Sphere Is= {0} ", 4 * Pi * redius * redius);
            Console.WriteLine("Volume of Sphere Is= {0} ", (4 / 3) * Pi * redius * redius * redius);

        }
    }
}
