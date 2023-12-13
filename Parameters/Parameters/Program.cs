using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Step 3: Instantiate an Employee object with type “string” as its generic parameter.
        Employee<string> stringEmployee = new Employee<string>(1, "John", "Doe");
        stringEmployee.Things = new List<string> { "Thing1", "Thing2", "Thing3" };

        // Step 4: Instantiate an Employee object with type “int” as its generic parameter.
        Employee<int> intEmployee = new Employee<int>(2, "Jane", "Doe");
        intEmployee.Things = new List<int> { 1, 2, 3, 4, 5 };

        // Step 5: Create a loop that prints all of the Things to the Console.
        PrintThings(stringEmployee);
        PrintThings(intEmployee);

    }

    // Helper method to print Things from an Employee object
    static void PrintThings<T>(Employee<T> employee)
    {
        Console.WriteLine($"Employee {employee.Id}: {employee.FirstName} {employee.LastName}");

        // Loop to print all Things
        foreach (var thing in employee.Things)
        {
            Console.WriteLine($"  {thing}");
        }

        Console.WriteLine();
    }
}