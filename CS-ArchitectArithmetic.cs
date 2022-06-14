using System;

namespace ArchitectArithmetic
{
    class Program
    {
        public static void Main(string[] args)
        {
            //store total calc area of floorplan
            double floorplan = Rectangle(2500, 1500) + Triangle(500, 750) + 0.5 * Circle(375);
            Console.WriteLine(floorplan);

            double price = floorplan * 180;
            Console.WriteLine($"The total cost is {Math.Round(price, 2)} pesos");
        }
        static double Rectangle(double length, double width)
        {
            return length * width;
        }
        static double Circle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        static double Triangle(double bottom, double height)
        {
            return 0.5 * bottom * height;
        }
    }
}