using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    class Guess
    {
        public int guessValue;

        public void Game()
        {
            var random = new Random();
            var rand = random.Next(1, 10);
            int guess;
            bool winner = false;

            Console.WriteLine("Guess the Random number between 1 and 10: ");
            for (var i = 4; i > 0; i--)
            {
                guess = Convert.ToInt32(Console.ReadLine());

                if(guess == rand)
                {
                    Console.WriteLine("Congradulations! You Won!");
                    winner = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect, Try Again");
                }

            }
            if(!winner)
            {
                Console.WriteLine("Unforturnately, you lost. The number was {0}", rand);
            }

        }
    }
}
