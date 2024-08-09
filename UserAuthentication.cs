using System;
using System.Collections.Generic;

class Program
{
    // Simple in-memory user data
    static Dictionary<string, string> users = new Dictionary<string, string>
    {
        { "user1", "password1" },
        { "user2", "password2" }
    };

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the authentication system!");

        // Prompt the user for a username
        Console.Write("Enter your username: ");
        string username = Console.ReadLine();

        // Prompt the user for a password
        Console.Write("Enter your password: ");
        string password = Console.ReadLine();

        // Authenticate the user
        if (AuthenticateUser(username, password))
        {
            Console.WriteLine("Authentication successful! Welcome, " + username + ".");
        }
        else
        {
            Console.WriteLine("Authentication failed! Incorrect username or password.");
        }

        // Wait for user to press a key before closing
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    // Method to authenticate user
    static bool AuthenticateUser(string username, string password)
    {
        // Check if the username exists and the password matches
        if (users.ContainsKey(username) && users[username] == password)
        {
            return true;
        }
        return false;
    }
}