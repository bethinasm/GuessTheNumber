using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GuessTheNumber
{
    internal class Oppgave
    {
        public void Run()
        {
                Random randomNumber = new Random();
                int number = randomNumber.Next(1, 101);

                Console.WriteLine("The program will find a random number between 1 - 100.");
                Console.WriteLine("Your task is to guess what the number is.");
                Thread.Sleep(2000);
                Console.WriteLine();
                Console.WriteLine("I have now picked a random number. \nWhat number do you think it is?");
                GuessingGame(number);
        }

        void GuessingGame(int number)
        {
            var usersGuess = Convert.ToInt32(Console.ReadLine());
            CheckIfClose(usersGuess, number);
        }

        private void CheckIfClose(int guess, int number)
        {
            if (guess < number)
            {
                Console.WriteLine("Higher");
                GuessingGame(number);
            }
            else if (guess > number)
            {
                Console.WriteLine("Lower");
                GuessingGame(number);
            }
            else
            {
                Console.WriteLine("Correct!");
                Console.WriteLine();

                Thread.Sleep(1500);

                Console.WriteLine("Would you like to play again?");
                Console.WriteLine("Enter [1] to play again \nEnter [2] to exit program");
                var userInput = Console.ReadLine();
                CheckIfRunAgain(userInput);
            }
        }

        private void CheckIfRunAgain(string userInput)
        {
            switch(userInput)

            {
                case "1":
                    Console.Clear();
                    Run();
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("The program will now shut down. \nThanks for playing!");
                    Thread.Sleep(1500);
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Not a valid input, try again.");
                    CheckIfRunAgain(userInput);
                    break;
            }
        }
    }
}