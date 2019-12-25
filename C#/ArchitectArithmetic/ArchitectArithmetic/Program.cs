using System;

namespace ArchitectArithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            var rectArea = Rectangle(4, 5);
            var circArea = Circle(4);
            var triArea = Triangle(10, 9);

            Console.WriteLine($"Rectangle area of {rectArea}");
            Console.WriteLine($"Circle area of {circArea}");
            Console.WriteLine($"Triangle area of {triArea}");
        }

        private static double Rectangle(double length, double width)
        {
            return length * width;
        }

        public static double Circle(double radius)
        {
            return Math.PI * Math.Pow(radius,radius);
        }

        public static double Triangle(double bottom, double height)
        {
            return 0.5 * (bottom * height);
        }
    }
}
