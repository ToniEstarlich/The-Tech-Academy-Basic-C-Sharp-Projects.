using System;

namespace Package_Express
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Display the welcome message
            Console.WriteLine("Welcome to Package Express. Please follow the instruction below.");

            // Step 2: Get package weight from the user
            Console.Write("Please enter the package weight: ");
            if (double.TryParse(Console.ReadLine(), out double packageWeight))
            {
                // Step 3: Check if the weight is greater than 50
                if (packageWeight > 50)
                {
                    Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                    return; // End the program
                }

                // Step 4: Get package width from the user
                Console.Write("Please enter the package width: ");
                double packageWidth = double.Parse(Console.ReadLine());

                // Step 5: Get package height from the user
                Console.Write("Please enter the package height: ");
                double packageHeight = double.Parse(Console.ReadLine());

                // Step 6: Get package length from the user
                Console.Write("Please enter the package length: ");
                double packageLength = double.Parse(Console.ReadLine());

                // Step 7: Check if the dimensions total greater than 50
                if (packageWidth + packageHeight + packageLength > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    return; // End the program
                }

                // Step 8: Calculate the quote
                double quote = (packageWidth * packageHeight * packageLength * packageWeight) / 100;

                // Step 9: Display the quote to the user
                Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");

                // Step 10: Display a thank you message
                Console.WriteLine("Thank you!");
            }
            else
            {
                // Step 11: Display an error message for invalid input
                Console.WriteLine("Invalid input. Please enter valid numeric values for package weight.");
            }

            // Step 12: Wait for user input before closing the console window
            Console.WriteLine("Press Enter to close the console window.");
            Console.ReadLine();
        }
    }
}
