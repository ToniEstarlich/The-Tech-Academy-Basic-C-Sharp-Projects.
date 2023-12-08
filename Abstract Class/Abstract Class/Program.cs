using System;

namespace Abstract_Class
{
    class Program
    {
        static void Main()
        {
            //Step 5: Inside the Main() method, instantiate an Employee object with firstName "Sample" and lastName "Student".
            Employee employee = new Employee
            {
                FirstName = "Sample",
                LastName = "Student"
            };

            // Call the SayName() method on the object
            employee.SayName();

            // Keep the console window open to see the result.
            Console.ReadLine();
        }
    }
}
