using System;

namespace _2D_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            //x1, y1, x2 и y2 

            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double width = Math.Abs(x1 - x2);
            double length = Math.Abs(y1 - y2);

            double area = width * length;

            double perimeter = 2 * (width + length);

            Console.WriteLine(area);
            Console.WriteLine(perimeter);


        }
    }
}
