// For the exceeding requirements the program only hides the words and leaves the commas and periods in place
using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference1 = new Reference("Moroni", 7, 45);
        Scripture scripture1 = new Scripture(reference1, "And charity suffereth long, and is kind, and envieth not, and is not puffed up, seeketh not her own, is not easily provoked, thinketh no evil, and rejoiceth not in iniquity but rejoiceth in the truth, beareth all things, believeth all things, hopeth all things, endureth all things.");
        string continueOrQuit = "";

        do
        {
            Console.Clear();
            Console.WriteLine($"{scripture1.GetScriptureString()}");
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            continueOrQuit = Console.ReadLine().ToLower();

            if (scripture1.IsCompletelyHidden())
            {
                continueOrQuit = "quit";
            }
            else
            {
                scripture1.HideRandomWords(3);
            }
        } while (continueOrQuit != "quit");
    }
}