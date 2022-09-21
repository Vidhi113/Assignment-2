using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class ex16
    {
        static void Main(string[] args)
        {
            //16.
            Console.WriteLine("Enter Your height : ");
            int height = Convert.ToInt16(Console.ReadLine());
            if (height < 150)
            {
                Console.WriteLine("The person is Dwarf.");
            }
            else if (height == 150)
            {
                Console.WriteLine("The person have average height.");
            }
            else
            {
                Console.WriteLine("The person is tall.");
            }

        }
    }
}
