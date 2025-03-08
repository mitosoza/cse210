using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int numberToAdd = -1;
        List<int> numbersList = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            numberToAdd = int.Parse(userInput);
            if (numberToAdd != 0)
            {
                numbersList.Add(numberToAdd);
            }
        } while (numberToAdd != 0);

        int listSum = numbersList.Sum();
        double listAverage = numbersList.Average();
        int listLargest = numbersList.Max();

        Console.WriteLine($"The sum is: {listSum}");
        Console.WriteLine($"The average is: {listAverage}");
        Console.WriteLine($"The largest number is: {listLargest}");
    }
}