using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Random randomGenerator = new Random();
        string playAgain;

        do
        {
            int magic = randomGenerator.Next(1, 101);
            int guess = -1;
            int count = 0;

            while (guess != magic)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                count++;

                if (guess < magic)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magic)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }

            Console.WriteLine($"You made {count} guess(es).");

            Console.Write("Do you want to play again? ");
            playAgain = Console.ReadLine();
        } while (playAgain == "yes");
    }
}