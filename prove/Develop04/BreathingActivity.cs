public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.") { }

    public override void StartActivity()
    {
        DisplayStartingMessage();
        PerformBreathing();
        DisplayEndingMessage();
    }

    private void PerformBreathing()
    {
        int elapsed = 0;
        while (elapsed + 6 <= _durationInSeconds) // 3s in + 3s out = 6s loop
        {
            Console.WriteLine("Breathe in...");
            PauseWithCountdown(3);
            Console.WriteLine("Breathe out...");
            PauseWithCountdown(3);
            elapsed += 6;
        }
    }
}