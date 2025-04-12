// For the exceeding requirements I made the program also display the possible points per goal. Also block users from recording an event on an already completed goal.

using System;

class Program
{
    static void Main(string[] args)
    {
        int choiceNumber = 0;
        int subChoiceNumber = 0;
        GoalManager goalManager = new GoalManager();

        do
        {
            goalManager.DisplayPlayerInfo();
            DisplayMenu();
            Console.Write("Select a choice from the menu: ");
            string userInput = Console.ReadLine();
            choiceNumber = int.Parse(userInput);

            switch (choiceNumber)
            {
                case 1:
                    // Create New Goal
                    DisplaySubMenu();
                    Console.Write("Which type of goal would you like to create? ");
                    string subUserInput = Console.ReadLine();
                    subChoiceNumber = int.Parse(subUserInput);
                    switch (subChoiceNumber)
                    {
                        case 1:
                            // Create Simple Goal
                            goalManager.CreateGoal("simple");
                            break;
                        case 2:
                            // Create Eternal Goal
                            goalManager.CreateGoal("eternal");
                            break;
                        case 3:
                            // Create Checklist Goal
                            goalManager.CreateGoal("checklist");
                            break;
                        default:
                            Console.WriteLine("Invalid choice, please try again.");
                            break;
                    }
                    break;
                case 2:
                    // List Goals
                    goalManager.ListGoals();
                    break;
                case 3:
                    // Save Goals
                    goalManager.SaveGoals();
                    break;
                case 4:
                    goalManager.LoadGoals();
                    break;
                case 5:
                    // Record Event
                    goalManager.RecordEvent();
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
        Console.WriteLine("\nMenu Options:");
        Console.WriteLine("  1. Create New Goal");
        Console.WriteLine("  2. List Goals");
        Console.WriteLine("  3. Save Goals");
        Console.WriteLine("  4. Load Goals");
        Console.WriteLine("  5. Record Event");
        Console.WriteLine("  6. Quit");
    }

    static void DisplaySubMenu()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
    }
}