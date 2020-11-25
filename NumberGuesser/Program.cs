using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Run the application information. */
            GetAppInfo(); 

            /* Ask the Player's information and greet him/her. */
            GreetUser();

            while(true)
            { 
                // Create a new Random Object
                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                // Initialized guess number variable 
                int guessNumber = 0;

                // Ask user for a number 
                Console.WriteLine("Guess a number between 1 and 10!");

                // Loop to ask for a number if the user didn't guess the correct number 
                while(guessNumber != correctNumber)
                {
                    string input = Console.ReadLine();

                    // Validate if it is a number
                    if(!int.TryParse(input, out guessNumber))
                    {
                        // Tell the user that the input is not a number from 1-10.
                        PrintColoredMessage(ConsoleColor.Yellow, "This is not an actual number, Pick from 1-10.");

                        // Keep going 
                        continue;
                    }
                    // If it is a number, then
                    // Cast to int and put in guess variable
                    guessNumber = Int32.Parse(input);

                    // Match guess to correct number 
                    if (guessNumber != correctNumber)
                    {
                        // Tell the user that the input is not the correct number.
                        PrintColoredMessage(ConsoleColor.Red, "Wrong Number, Please Try Again!");
                    }
                }

                // Tell the user that the guess number is correct.
                PrintColoredMessage(ConsoleColor.Blue, "Your Guess is Correct");

                PlayAgain();

                // Get the user answer
                string answerPlay = Console.ReadLine().ToUpper();
                if (answerPlay == "Y")
                {
                    continue;
                }
                else if (answerPlay == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        static void GetAppInfo()
        {
            // Set application variables 
            string appName = "Number Guesser";
            string appVersion = "1.0.0.0";
            string appAuthor = "Arjie";

            // Change the text color in the console 
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("{0} : Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset the foreground color
            Console.ResetColor();
        }

        static void GreetUser()
        {
            // Ask users name 
            Console.WriteLine("What is your name? ");

            // Get the user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0} let's play number guessing game...", inputName);
        }

        static void PrintColoredMessage(ConsoleColor color, string message) // Set an argument color, message
        {
            // Change the text color in the console
            Console.ForegroundColor = color;

            // Tell the user, the input is not a number
            Console.WriteLine(message);

            // Reset the foreground color
            Console.ResetColor();
        }

        static void PlayAgain()
        {
            // Ask the user to play again
            Console.WriteLine("Play Again? [Y/N]");
        }
    }
}
