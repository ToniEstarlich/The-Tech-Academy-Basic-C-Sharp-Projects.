using System;
using System.Diagnostics.Eventing.Reader;


namespace If__Else_testaments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Rod";

            if (name == "Jill")
            {
                Console.WriteLine("Your name is Jill");
            }
            else if (name == "Rayan")
            {
                Console.WriteLine("Your name is not Jill");
            }
            else
            {
                Console.WriteLine("Your name is not Jill. Your name is not Rayan.");
            }
            Console.ReadLine();
        }
    }
}