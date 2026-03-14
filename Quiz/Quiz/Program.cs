using System;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            // ITEM 1: One-dimensional array with 6 names
            //         Print using foreach loop


            string[] classmates = { "Marke", "Glenn", "Ahyian", "Ivan", "Nathaniel", "Lamar" };

            Console.WriteLine("Item 1: Names of Classmates");
            foreach (string name in classmates)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();

            // ITEM 2: Two-dimensional array (2 rows x 3 columns)
            //         Initialize with first 6 letters of the alphabet


            char[,] letters = { { 'A', 'B', 'C' },
                                { 'D', 'E', 'F' } };

            Console.WriteLine("Item 2: Two-Dimensional Array (2x3)");
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(letters[row, col] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

         
            // ITEM 3: String - check if it contains "hello"


            string message = "Hey there, hello world! Welcome to C# programming.";

            Console.WriteLine("Item 3: String Contains Check");
            Console.WriteLine("Message: " + message);

            if (message.Contains("hello"))
            {
                Console.WriteLine("The message contains the string \"hello\".");
            }
            else
            {
                Console.WriteLine("The message does not contain the string \"hello\".");
            }

            Console.ReadLine();
        }
    }
}
