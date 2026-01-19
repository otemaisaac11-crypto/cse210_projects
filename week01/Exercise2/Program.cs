using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your percentage grade (0-100)? ");
        string input = Console.ReadLine();

        if (!int.TryParse(input, out int grade))
        {
            Console.WriteLine("Invalid input. Please enter a whole number.");
            return;
        }

        if (grade < 0 || grade > 100)
        {
            Console.WriteLine("Please enter a number between 0 and 100.");
            return;
        }

        string letter;

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter grade is {letter}.");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class.");
        }
        else
        {
            Console.WriteLine("Keep trying — you'll do better next time!");
        }
}

}