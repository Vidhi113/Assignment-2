using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class ex24
    {
        static void Main(string[] args)
        {
            //24.
            int cprice, sprice, plamt;
            Console.Write("Input Cost Price: ");
            cprice = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input Selling Price: ");
            sprice = Convert.ToInt32(Console.ReadLine());
            if (sprice > cprice)
            {
                plamt = sprice - cprice;
                Console.WriteLine("You can booked your profit amount : {0}", plamt);
            }
            else if (cprice > sprice)
            {
                plamt = cprice - sprice;
                Console.WriteLine("You got a loss of amount : {0}", plamt);
            }
            else
            {
                Console.WriteLine("You are running in no profit no loss condition.");
            }  

        }
    }
}
