using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Catch
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Declare variable to store user input and calculated birth year
            int age;
            int birthYear;

            try
            {
                //Ask the user for their age
                Console.Write("Enter your age:");

                //Parse user input and handle exceptions
                age = int.Parse(Console.ReadLine());

                //Check if the is zero or negative
                if (age <= 0)
                {
                    //Throw a custom exception for zero or negative age
                    throw new ArgumentException("Age must be a positive number.");
                }

                //Calculate birth year based in the current year
                birthYear = DateTime.Now.Year - age;

                //Display the year the user was born
                Console.WriteLine($"You were born in the year {birthYear}");
            }
            catch (FormatException)
            {
                //Handle the exception if the user enters non-integer input
                Console.WriteLine("Pleade enter a valid interger for age.");
            }
            catch (ArgumentException ex)
            {
                //Handle the custom exception for zero or negatice age
                Console.WriteLine(ex.Message);
            }
            catch (Exception)
            {
                //Handle any other general exceptions
                Console.WriteLine("An unexpected error ocurred.");
            }

        }
    }
}
