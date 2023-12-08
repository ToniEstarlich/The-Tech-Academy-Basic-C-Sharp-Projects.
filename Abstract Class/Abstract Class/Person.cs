using System;

    //Step 1: Create an abstract class called Person with two properties:
    public abstract class Person
    {
        // Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Step 2: Method to say the name
        public abstract void SayName();
    }

    // Step 3: Create another class called Employee and have it inherit from the Person class.
    public class Employee : Person
    {
        // Step 4: Implement the SayName() method inside of the EMployee class.
        public override void SayName()
        {
            Console.WriteLine($"Employee's name: {FirstName} {LastName}");
        }
    }
