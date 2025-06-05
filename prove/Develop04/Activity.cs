public abstract class Activity
{
    private string _name;
    private string _description;
    protected int _durationInSeconds;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void SetDuration()
    {
        Console.Write("Enter duration in seconds: ");
        _durationInSeconds = int.Parse(Console.ReadLine());
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"\n--- {_name} Activity ---");
        Console.WriteLine(_description);
        SetDuration();
        Console.WriteLine("Prepare to begin...");
        PauseWithSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nGood job!");
        Console.WriteLine($"You have completed the {_name} activity for {_durationInSeconds} seconds.");
        PauseWithSpinner(3);
    }

    public void PauseWithSpinner(int seconds)
    {
        var spinnerChars = new[] { '|', '/', '-', '\\' };
        for (int i = 0; i < seconds * 4; i++)
        {
            Console.Write(spinnerChars[i % spinnerChars.Length]);
            Thread.Sleep(250);
            Console.Write("\b");
        }
    }

    public void PauseWithCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public abstract void StartActivity();
}