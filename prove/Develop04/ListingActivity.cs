public class ListingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _userEntries;
    private Random _random;

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who have you helped recently?",
            "What are some recent blessings?",
            "Who are some of your personal heroes?"
        };
        _userEntries = new List<string>();
        _random = new Random();
    }

    public override void StartActivity()
    {
        DisplayStartingMessage();
        PerformListing();
        DisplayEndingMessage();
    }

    private string GetRandomPrompt() => _prompts[_random.Next(_prompts.Count)];

    private void PerformListing()
    {
        Console.WriteLine($"\nPrompt: {GetRandomPrompt()}");
        Console.WriteLine("You will have a few seconds to think, then begin listing:");

        PauseWithCountdown(5);

        DateTime endTime = DateTime.Now.AddSeconds(_durationInSeconds);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                _userEntries.Add(input);
            }
        }

        Console.WriteLine($"\nYou listed {_userEntries.Count} items!");
    }
}
