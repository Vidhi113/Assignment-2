using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class ex19
    {
        static void Main(string[] args)
        {
            //19.
            Console.WriteLine("Enter Your Name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Your Roll No : ");
            int r_no = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Your Marks of Physics : ");
            int phy = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Your Marks of Chemestry : ");
            int c = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Your Marks of Computer Application : ");
            int ca = Convert.ToInt16(Console.ReadLine());
            int tot = c + ca + phy;
            double per = tot / 3;
            Console.WriteLine("Name of Student : {0}", name);
            Console.WriteLine("Marks in Physics : {0}", phy);
            Console.WriteLine("Marks in Chemistry : {0}", c);
            Console.WriteLine("Marks in Computer Application : {0}", ca);
            Console.WriteLine("Total Marks : {0}", tot);
            Console.WriteLine("Percentage : {0}", per);
            Console.WriteLine("Division : First ");

        }
    }
}
