using System;

class Program
{
    static void Main(string[] args)
    {
        var reference = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all they ways acknowledge him, and he shall direct they paths.";
        var scripture = new Scripture(reference, text);

        while (true)
        {
            Console.Clear();
            scripture.Display();

            if (scripture.AllHidden())
            {
                Console.WriteLine("\nAll words have been hidden. Program will end.");
                break;
            }

            Console.Write("\nPress Enter to continue or type 'quit' to exit: ");
            string input = Console.ReadLine().Trim().ToLower();

            if (input == "quit")
                break;

            scripture.HideRandomWords();
        }
    }
}