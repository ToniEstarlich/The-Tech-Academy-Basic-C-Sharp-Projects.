using System;
using System.Collections.Generic;

    // Step 1 Make the EMployee class take a generic type parameter.
    internal class Employee<T>
    {
    // Step 2: Add a property to the Employee class called "things" and have its data type be a generic list matching the generic type of the class.
    public List<T> Things { get; set; } = new List<T>();

    // Properties
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Constructor

    public Employee(int id, string firstName, string lastName)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
    }
  }
