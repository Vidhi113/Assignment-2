using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class ex25
    {
        static void Main(string[] args)
        {
            //25.
            Console.WriteLine("Enter Customer Name :");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Customer Id :");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Consumed Unit :");
            int unit = Convert.ToInt32(Console.ReadLine());
            double bill=0, charge=0;
            if (unit <= 199)
            {
                charge = 1.20;
                bill = unit * 1.20;
            }
            if (unit >= 200 && unit <= 400)
            {
                charge = 1.50;
                bill = unit * 1.50;
            }
            if (unit >= 400 && unit <= 600)
            {
                charge = 1.80;
                bill = unit * 1.80;
            }
            if (unit >= 600)
            {
                charge = 2.00;
                bill = unit * 2.00;
            }
            Console.WriteLine("Consumed Unit = {0}", unit);
            Console.WriteLine("Amount Charges = @{0} per Unit = {1}", charge, charge * unit);
            if (bill >= 400)
            {
                int Scharge = 15;
                Console.WriteLine("Surchage Amount = {0}", Scharge * charge / 100);
                Console.WriteLine("Net Amount Paid by the Customer = {0}", bill + Scharge);
            }
            else
            {
                Console.WriteLine("Net Amount Paid by the Customer = {0}", bill);
            }

        }
    }
}
