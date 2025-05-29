using System;


class Program
{
    private List<Scripture> _scriptures = new List<Scripture>();
    private Scripture _currentScripture;

    public void Run()
    {
        _currentScripture = new Scripture("Proverbs 3:5", "Trust in the Lord with all thine heart and lean not unto thine own understanding");

        while (true)
        {
            ClearConsole();
            DisplayScripture();

            if (_currentScripture.AllWordsHidden())
            {
                Console.WriteLine("\nAll words have been hidden. Program will end.");
                break;
            }

            string input = GetUserInput();
            if (input == "quit")
                break;

            _currentScripture.HideRandomWords();
        }
    }

    private void ClearConsole()
    {
        Console.Clear();
    }

    private void DisplayScripture()
    {
        Console.WriteLine(_currentScripture.GetDisplayText());
    }

    private string GetUserInput()
    {
        Console.Write("\nPress Enter to continue or type 'quit' to exit: ");
        return Console.ReadLine().Trim().ToLower();
    }

    static void Main(string[] args)
    {
        new Program().Run();
    }
}