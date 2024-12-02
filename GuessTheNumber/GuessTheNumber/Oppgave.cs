using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    internal class Oppgave
    {
        public void Run()
        {
            Random rand = new Random();
            int number = rand.Next(1, 101);

            Console.WriteLine("The program will find a random number between 1 - 100.");
            Console.WriteLine("Your task is to guess what the number is.");
            Thread.Sleep(3000);
            Console.WriteLine();
            Console.WriteLine("I have now picked a random number. \nWhat number do you think it is?");
            
            var userInput = Console.ReadLine();
        }
    }
}
