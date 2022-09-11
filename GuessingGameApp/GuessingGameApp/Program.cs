using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGameApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess;
            int number;
            int guesses;
            string response;
            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                response = "";
                number = random.Next(min, max + 1);

                while (guess != number)
                {
                    Console.WriteLine("Guess a number " + min + "-" + max + " : " );
                    guess = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Guess: " + guess);
                    
                    if(guess > number)
                    {
                        Console.WriteLine(guess + "is to high!");

                    }
                    else if(guess < number)
                    {
                        Console.WriteLine(guess + "is too low");

                        Console.WriteLine("Would you like to play again (Y/N): ");
                        response = Console.ReadLine();
                        response = response.ToUpper();
                        
                        if(response == "Y")
                        {
                            playAgain = true;

                        }

                        else
                        {
                            playAgain = false;
                        }


                    }
                    guesses++;




                }
                Console.WriteLine("Number:" + number);
                Console.WriteLine("You Win!");
                Console.WriteLine("Guesses: " + guesses);




            }
            Console.WriteLine("Thanks for playing! ... I guess");

            Console.ReadKey();

        }
    }
}
