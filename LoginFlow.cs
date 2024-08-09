using System;

class Program
{
    static void Main(string[] args)
    {
        // Predefined username and password for demonstration
        string correctUsername = "admin";
        string correctPassword = "password123";

        // Prompt user for username and password
        Console.Write("Enter your username: ");
        string username = Console.ReadLine();

        Console.Write("Enter your password: ");
        string password = Console.ReadLine();

        // Check if the entered username and password are correct
        if (username == correctUsername && password == correctPassword)
        {
            Console.WriteLine("Login successful! Welcome, " + username + ".");
        }
        else
        {
            Console.WriteLine("Login failed! Incorrect username or password.");
        }

        // Wait for user to press a key before closing
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}