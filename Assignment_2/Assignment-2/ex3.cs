using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class ex3
    {
        static void Main(string[] args)
        {
            //3.
            Console.WriteLine("Input first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input Operation: ");
            char o = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Input Second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            switch (o)
            {
                case '+':
                    Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
                    break;

                case '-':
                    Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
                    break;

                case '*':
                    Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
                    break;

                case '/':
                    Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
                    break;

                case '%':
                    Console.WriteLine("{0} % {1} = {2}", a, b, a % b);
                    break;

                default:
                    Console.WriteLine("Invalid Operation ... ");
                    break;
            }

        }
    }
}
