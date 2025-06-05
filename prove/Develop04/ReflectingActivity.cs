public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private Random _random;

    public ReflectingActivity() : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have.")
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "What did you learn about yourself?",
            "What made this time different?",
            "How did you feel afterward?",
            "What can you take from this going forward?"
        };

        _random = new Random();
    }

    public override void StartActivity()
    {
        DisplayStartingMessage();
        PerformReflection();
        DisplayEndingMessage();
    }

    private string GetRandomPrompt() => _prompts[_random.Next(_prompts.Count)];

    private string GetRandomQuestion() => _questions[_random.Next(_questions.Count)];

    private void PerformReflection()
    {
        Console.WriteLine("\nPrompt:");
        Console.WriteLine($"-- {GetRandomPrompt()}");
        Console.WriteLine("Consider the following questions:");

        int timeRemaining = _durationInSeconds;
        while (timeRemaining > 0)
        {
            Console.WriteLine($"> {GetRandomQuestion()}");
            PauseWithSpinner(5);
            timeRemaining -= 5;
        }
    }
}
