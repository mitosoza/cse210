// For the exceeding requirements I added an option to erase the Journal
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
                    // Erase
                    Console.WriteLine("Are you sure you want to erase the journal? (Y/N)");
                    string eraseConfirmation = Console.ReadLine();
                    if (eraseConfirmation.ToUpper() == "Y")
                    {
                        Console.WriteLine("What is the filename?");
                        string eraseFilename = Console.ReadLine();
                        myJournal._entries.Clear();
                        myJournal.SaveToFile(eraseFilename);
                        Console.WriteLine("Journal erased.");
                    }
                    break;
                case 6:
                    // Quit
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        } while (choiceNumber != 6);
    }

    static void DisplayMenu()
    {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Erase");
        Console.WriteLine("6. Quit");
    }
}