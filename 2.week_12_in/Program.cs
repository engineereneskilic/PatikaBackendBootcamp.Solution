using System;

namespace _2.week_12_in
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void PrintPoint(in Point point)
            {
                Console.WriteLine($"x: {point.X}  y: {point.Y}");
            }

            Point point = new Point(18, 78);

            PrintPoint(in point);

            Console.ReadKey();

        }
    }
}
