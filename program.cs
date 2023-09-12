
using System;

namespace Glazing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double width = 0;
            double height = 0;

            const double max_width = 5.00;

            Console.WriteLine("enter width of window");

            width = double.Parse(Console.ReadLine());  

            if (width > max_width)
            {
                Console.WriteLine("Too wide");

            } else
            {
                Console.WriteLine("Good");
            }

        }
    }
}
