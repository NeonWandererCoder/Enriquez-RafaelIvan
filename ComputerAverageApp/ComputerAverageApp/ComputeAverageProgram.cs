using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerAverageApp
{
    internal class ComputeAverageProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 5 grades separated by new line:");

            // Input 5 grades
            double g1 = Convert.ToDouble(Console.ReadLine());
            double g2 = Convert.ToDouble(Console.ReadLine());
            double g3 = Convert.ToDouble(Console.ReadLine());
            double g4 = Convert.ToDouble(Console.ReadLine());
            double g5 = Convert.ToDouble(Console.ReadLine());

            // Compute the average
            double average = (g1 + g2 + g3 + g4 + g5) / 5;

            // Round the average using Math class
            double roundedAverage = Math.Round(average);

            // Display results
            Console.WriteLine("The average is " + average + " and round off to " + roundedAverage);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
