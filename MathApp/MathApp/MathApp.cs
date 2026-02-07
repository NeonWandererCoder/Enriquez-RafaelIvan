using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp
{
    internal class MathApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Math Class Cafe ===");
            Console.WriteLine();

            double drinkPrice = 14.50;
            double pastries = 3.0;
            double containerSize = 64.0;
            int stockTarget = 50;
            int stockCurrent = 38;

            // 1. Math.Pow
            double coasterArea = 3.14 * Math.Pow(4, 2);
            Console.WriteLine("Coaster Area: " + coasterArea);

            // 2. Math.Sqrt
            double signSide = Math.Sqrt(containerSize);
            Console.WriteLine("Sign Side Length: " + signSide);

            // 3. Math.Abs
            int stockDiff = Math.Abs(stockCurrent - stockTarget);
            Console.WriteLine("Stock Difference: " + stockDiff);

            // 4. Math.Ceiling
            double boxesNeeded = Math.Ceiling(pastries / 2.5);
            Console.WriteLine("Boxes to Order: " + boxesNeeded);

            // 5. Math.Truncate
            double priceTag = Math.Truncate(drinkPrice);
            Console.WriteLine("Whole Dollar Amount: " + priceTag);

            Console.WriteLine("\nDone. Press any key.");
            Console.ReadKey();
        }
    }
}
