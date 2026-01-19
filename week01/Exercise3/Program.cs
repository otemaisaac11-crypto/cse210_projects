using System;

class Program
{
    static void Main(string[] args)
    {

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        
        Console.Write("What is your guess?");
        int userGuess = int.Parse(Console.ReadLine());

        if (userGuess < magicNumber)
        {
            Console.WriteLine("Higher!");
        }
        else if (userGuess > magicNumber)
        {
            Console.WriteLine("Lower!");
        }
        else
        {
            Console.WriteLine("You guessed it!");
        }
        while (userGuess != magicNumber)
        {
            Console.Write("What is your guess?");
            userGuess = int.Parse(Console.ReadLine());

            if (userGuess < magicNumber)
            {
                Console.WriteLine("Higher!");
            }
            else if (userGuess > magicNumber)
            {
                Console.WriteLine("Lower!");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}