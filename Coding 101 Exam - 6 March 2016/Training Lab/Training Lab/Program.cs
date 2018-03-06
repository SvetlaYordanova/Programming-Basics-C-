using System;

namespace Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            double h = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());

            w = w * 100;
            h = h * 100;

            double dyljina = Math.Floor(h /120);

            double chirina = Math.Floor((w - 100) / 70);

            double place = (dyljina * chirina);

            Console.WriteLine(place - 3);

        }
    }
}
