class Menu
{
    private List<string> options = new List<string>
    {
        "1. New Entry",
        "2. Display Entries",
        "3. Save Entries",
        "4. Load Entries",
        "5. Exit"
    };

    public void ShowMenu()
    {
        Console.WriteLine("\nJournal Menu:");
        foreach (var option in options)
        {
            Console.WriteLine(option);
        }
    }
}