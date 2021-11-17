using System;

namespace Chapter4ElephantExercisePage194
{
    class Program
    {
        static void Main(string[] args)
        {
            // create the elephants
            Elephant lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
            Elephant lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };

            Console.WriteLine("Welcome to the elephant game.\n " +
            "Please enter a value of 1 to call the elephant 1.\n" +
            "Please enter a value of 2 to call the elephant 2.\n" +
            "Please enter a value of 3 to resort the order of the elephants that you want to call.\n" +
            "Or please enter a value of 4 to end this game.");
            
            string userResponse = Console.ReadLine();

            WhoAmI(userResponse);


        }
    }
}
