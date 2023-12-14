using System;
class Program
{
    static void Main()
    {

        // Creating an object of the Number struct and assigning an amount using the constructor
        Number myNumber = new Number(123.45m);

        // Printing the amount to the console
        Console.WriteLine($"Amount: {myNumber.Amount}");

    }
  }

