using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class ex4
    {
        static void Main(string[] args)
        {
            //4.
            double Pi = 3.14;
            Console.WriteLine("Input The Radius Of The Circle :");
            int redius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Area Of The Circle Is = {0} ", Pi * redius * redius);
            Console.WriteLine("The Perimeter Of The Circle Is = {0} ", Pi * 2 * redius);

        }
    }
}