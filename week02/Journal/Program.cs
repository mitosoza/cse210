using System;

class Program
{
    static void Main(string[] args)
    {
        int choiceNumber = 0;
        Journal myJournal = new Journal();

        do
        {
            Entry myEntry = new Entry();
            PromptGenerator myPromptGenerator = new PromptGenerator();

            DisplayMenu();
            Console.Write("What would you like to do? ");
            string userInput = Console.ReadLine();
            choiceNumber = int.Parse(userInput);

            switch (choiceNumber)
            {
                case 1:
                    // Write
                    string randomPrompt = myPromptGenerator.GetRandomPrompt();
                    Console.WriteLine(randomPrompt);
                    string userResponse = Console.ReadLine();
                    DateTime theCurrentTime = DateTime.Now;
                    string dateText = theCurrentTime.ToShortDateString();
                    myEntry._date = dateText;
                    myEntry._promptText = randomPrompt;
                    myEntry._entryText = userResponse;
                    myJournal.AddEntry(myEntry);
                    break;
                case 2:
                    // Display
                    myJournal.DisplayJournal();
                    break;
                case 3:
                    // Load
                    Console.WriteLine("What is the filename?");
                    string loadFilename = Console.ReadLine();
                    myJournal.LoadFromFile(loadFilename);
                    break;
                case 4:
                    // Save
                    Console.WriteLine("What is the filename?");
                    string saveFilename = Console.ReadLine();
                    myJournal.SaveToFile(saveFilename);
                    break;
                case 5:
                    // Quit
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        } while (choiceNumber != 5);
    }

    static void DisplayMenu()
    {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
    }
}