// For exceeding requirements I added code so the questions in the Reflecting Activity do not repeat until they are all used.

using System;

class Program
{
    static void Main(string[] args)
    {
        int choiceNumber = 0;

        do
        {
            Console.Clear();
            DisplayMenu();
            Console.Write("Select a choice from the menu: ");
            string userInput = Console.ReadLine();
            choiceNumber = int.Parse(userInput);

            switch (choiceNumber)
            {
                case 1:
                    // Breathing activity
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Run();

                    break;
                case 2:
                    // Reflecting activity
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    reflectingActivity.Run();

                    break;
                case 3:
                    // Listing activity
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Run();

                    break;
                case 4:
                    // Quit
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        } while (choiceNumber != 4);
    }

    static void DisplayMenu()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Start breathing activity");
        Console.WriteLine("  2. Start reflecting activity");
        Console.WriteLine("  3. Start listing activity");
        Console.WriteLine("  4. Quit");
    }
}