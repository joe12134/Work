using System;


namespace Glazing
{
    internal class Program
    {
        static void Main(string[] args)
        {


            const double Max_Width = 5.0;
            const double Min_Width = 0.5;
            const double Max_Height = 3.0;
            const double Min_Height = 0.75;
         
            Console.WriteLine("Enter Width Then click Enter");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Height then click Enter");
            double height= double.Parse(Console.ReadLine());


            if (width > Max_Width)
            {
                Console.WriteLine("Width too big, Using max");
                width = Max_Width;
            }
            if (width < Min_Width)
            {
                Console.WriteLine("Width too small, Using min");
                width = Min_Width;
            }


            if (height > Max_Height)
            {
                Console.WriteLine("Height too big, Using max");
                height = Max_Height;
            }
            if (height < Min_Height)
            {
                Console.WriteLine("Height too small, Using min");
                height = Min_Height;
            }

            double woodLength = width * height * 2 * 3.25;
            double glassArea = width * height * 2;

            Console.WriteLine($"Wood Length is: {woodLength}");
            Console.WriteLine($"Area of glass is: {glassArea}");

        }
    }
}
