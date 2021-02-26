using System;

/* Create a user Login System, where the user can first register and then Login in. The Program should check if the user has entered the correct username and password, wenn login in (so the same ones that he used when registering).
As we haven't covered storing data yet, just create the program in a way, that registering and logging in, happen in the same execution of it.
User If statements and User Input and Methods to solve the challenge. */

namespace IfChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! To register please follow the steps below.");
            string registeredUsername = getUserInput("a new username");
            string registeredPassword = getUserInput("a new password");
            Console.WriteLine("Processing...");
            Console.WriteLine("Thank you, your credentials have been saved.");

            Console.WriteLine("To login please enter your saved credentials.");
            string loginUsername = getUserInput("your username");
            string loginPassword = getUserInput("your password");
            Console.WriteLine("Processing...");

            bool checkedUsername = compareInputs(registeredUsername, loginUsername);
            bool checkedPassword = compareInputs(registeredPassword, loginPassword);

            authenticateUser(checkedUsername, checkedPassword, loginUsername);
            
        }

        public static string getUserInput(string requiredField)
        {
            Console.WriteLine("Please enter {0}:", requiredField);
            return Console.ReadLine();
        }

        public static bool compareInputs(string savedString, string newString)
        {
            return savedString.Equals(newString);
        }

        public static void authenticateUser(bool checkedUsername, bool checkedPassword, string username)
        {
            if (checkedUsername && checkedPassword)
            {
                Console.WriteLine("Welcome back, {0}. You were successfully logged in.", username);
            }
            else
            {
                Console.WriteLine("We're sorry, but there was an error during login. Please make sure you have entered a valid username and password.");
            }
        }
    }
}
