using System;

namespace ArchitectArithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateTotalCost();
        }

        private static void CalculateTotalCost()
        {
            Console.WriteLine("What monument would you like to work with? Type T for Teotihuacan, TM for the Taj Mahal and GMM for the Great Mosque of Mecca");
            var decision = Console.ReadLine();


            switch (decision)
            {
                case "T":
                    CalculateTeotihuacanCost();
                    break;
                case "TM":
                    CalculateTajMahalCost();
                    break;
                case "GMM":
                    CalculateGreatMosqueCost();
                    break;
                default:
                    Console.WriteLine("Invalid monument selected");
                    break;
            }
        }

        private static void CalculateTeotihuacanCost()
        {
            var rectArea = Rectangle(2500, 1500);
            var circArea = Circle(375);
            var triArea = Triangle(500, 750);

            var teotihuacanArea = rectArea + triArea + (circArea / 2);

            var totalCost = teotihuacanArea * 180;
            Console.WriteLine($"Total Cost of the ancient city of Teotihuacan in mexico is { Math.Round(totalCost) } pesos!");
        }

        private static void CalculateTajMahalCost()
        {
            var rectArea = Rectangle(90.5, 90.5);
            var triArea = Triangle(24, 24);

            var tajMahalArea = rectArea - (triArea * 4);

            var totalCost = tajMahalArea * 180;
            Console.WriteLine($"Total Cost of the Taj Mahal in Arga india is { Math.Round(totalCost) } pesos!");
        }

        private static void CalculateGreatMosqueCost()
        {
            var smallRectArea = Rectangle(106, 84);
            var triArea = Triangle(84, 264);
            var largeRect = Rectangle(390, 264);


            var greatMosqueArea = largeRect - (smallRectArea * 2) - triArea;
            var totalCost = greatMosqueArea * 180;

            Console.WriteLine($"Total Cost of the Great Mosque in Mecca, Saudi Arabia is { Math.Round(totalCost) } pesos!");
        }

        //area=length×width
        private static double Rectangle(double length, double width)
        {
            return length * width;
        }

        //area=π×radius^2
        public static double Circle(double radius)
        {
            return Math.PI * (Math.Pow(radius, 2));
        }

        //area=0.5×bottom×height
        public static double Triangle(double bottom, double height)
        {
            return 0.5 * (bottom * height);
        }
    }
}