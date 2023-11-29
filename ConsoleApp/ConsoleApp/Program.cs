using System;


namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Takes an input from the user
            Console.Write("Enter a number:");
            string userInput = Console.ReadLine();

            //Convert the input to a double (assuming valid input)
            double number = Convert.ToDouble(userInput);

            //Multiplies the input by 50
            double result1 = number * 50;
            Console.WriteLine($"Result 1: {result1}");

            //Adds 25 to the input 
            double result2 = number + 25;
            Console.WriteLine($"Result 3: {result2}");

            //Divides the input by 12.5
            double result3 = number / 12.5;
            Console.WriteLine($"Result 3: {result3}");

            //Checks if the input is greater than 50
            bool result4 = number > 50;
            Console.WriteLine($"Result 4: {result4}");

            //Divides the input by 7 and prints the remainder
            double remainder = number % 7;
            Console.WriteLine($"Result 5 (remainder): {remainder}");


        }
    }
}
