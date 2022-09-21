using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class ex5
    {
        static void Main(string[] args)
        {
            //5.
            Console.WriteLine("Input Distance :");
            int distance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input Time(hour) :");
            int hr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input Time(minutes) :");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input Time(seconds) :");
            int sec = Convert.ToInt32(Console.ReadLine());
            float timeSec = (hr * 3600) + (min * 60) + sec;
            float mps = distance / timeSec;
            float kph = (distance / 1000.0f) / (timeSec / 3600.0f);
            float mph = kph / 1.609f;

            Console.WriteLine("Your speed in metres/sec is {0}", mps);
            Console.WriteLine("Your speed in km/h is {0}", kph);
            Console.WriteLine("Your speed in miles/h is {0}", mph);

        }
    }
}
