using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int gradePercentage = int.Parse(userInput);
        string gradeLetter = "";

        if (gradePercentage >= 90)
        {
            gradeLetter = "A";
        }
        else if (gradePercentage >= 80)
        {
            gradeLetter = "B";
        }
        else if (gradePercentage >= 70)
        {
            gradeLetter = "C";
        }
        else if (gradePercentage >= 60)
        {
            gradeLetter = "D";
        }
        else
        {
            gradeLetter = "F";
        }


        if (gradePercentage >= 70)
        {
            Console.WriteLine($"Congratulation! you passed the class with a '{gradeLetter}' grade.");
        }
        else
        {
            Console.WriteLine($"Sorry, you failed the class with a '{gradeLetter}' grade.");
        }
    }
}