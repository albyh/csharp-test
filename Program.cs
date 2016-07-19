using System;


namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt user to enter a name.
            Console.WriteLine("Enter your name, please:");
            // Now read the name entered
            string name = Console.ReadLine();
            // Greet the user with the entered name
            Console.WriteLine("Hello, " + name);
            // Wait for the user to acknowledge
            Console.WriteLine("Press Enter to quit...");
            Console.Read();
        }
    }
}
