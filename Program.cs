using System;
using System.Security.Cryptography.X509Certificates;

namespace HelloTest
{
    internal class Program
    {           
        public static void Main(string[] args)
        {
            // Pick random number

            var random = new Random();
            var randomNumber = random.Next(1, 10);
            
            // Prompt user to guess
            Console.WriteLine("Pick a number between 1 and 10");
           
            // if correct end
            var running = true;
            while (running)
            {
                var guess = Console.ReadLine();
                int.TryParse(guess, out int guessInt);
                
                if (guessInt == randomNumber)
                {
                    Console.WriteLine("Nice job");
                    running = false;
                    continue;
                }
                // if not tell high or low
                if (guessInt > randomNumber)
                {
                    Console.WriteLine("Too high, try again.");
                }

                if (guessInt < randomNumber)
                {
                    Console.WriteLine("Too low, try again");
                }
            }
            

        }
    }
}