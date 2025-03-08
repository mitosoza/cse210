using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        int userGuess = 0;

        do
        {
            Console.Write("What is your guess? ");
            string userInput = Console.ReadLine();
            userGuess = int.Parse(userInput);

            if (userGuess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (userGuess > magicNumber)
            {
                Console.WriteLine("Lower");
            }

        } while (userGuess != magicNumber);

        Console.WriteLine("Congratulations! You guessed it!");
    }
}