using System;
using System.ComponentModel.DataAnnotations;

class MainProgram
{
    //static void Main(string[] args)
    
    int optionNumber;
    string journalEntry;

    New_Entry newEntry = new New_Entry();
    Random_Prompt randomPrompt = new Random_Prompt();
    Menu menu = new Menu();
    Save save = new Save();
    Load load = new Load();
    
    public void Run()
    {
        bool running = true;

        while (running)
        {
            menu.ShowMenu();
            Console.Write("Choose an option: ");
            optionNumber = int.Parse(Console.ReadLine());

            switch (optionNumber)
            {
                case 1:
                    journalEntry = randomPrompt.RandomPrompt();
                    Console.WriteLine("Prompt: " + journalEntry);
                    Console.Write("Your Entry: ");
                    string response = Console.ReadLine();
                    newEntry.entries.Add($"Prompt: {journalEntry} \nEntry: {response}");
                    break;
                case 2:
                    newEntry.DisplayEntries();
                    break;
                case 3:
                    save.SaveToFile(newEntry.entries);
                    break;
                case 4:
                    newEntry.entries = load.ReadFromFile();
                    break;
                case 5:
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }

    static void Main(string[] args)
    {
        MainProgram program = new MainProgram();
        program.Run();
    } 

}