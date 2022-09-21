using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class ex20
    {
        static void Main(string[] args)
        {
            //20.
            Console.WriteLine("Enter Temperature : ");
            int temp = Convert.ToInt32(Console.ReadLine());
            if (temp < 0)
            {
                Console.WriteLine("Freezing weather");
            }
            else if (temp < 10 && temp > 0)
            {
                Console.WriteLine("Very Cold weather");
            }
            else if (temp < 20 && temp > 10)
            {
                Console.WriteLine("Cold weather");
            }
            else if (temp < 30 && temp > 20)
            {
                Console.WriteLine("Normal in Temp");
            }
            else if (temp < 40 && temp > 30)
            {
                Console.WriteLine("Its Hot");
            }
            else { Console.WriteLine("Its Very Hot"); }

        }
    }
}
