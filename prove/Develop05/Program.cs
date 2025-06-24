using System;

class Program
{
    static void Main(string[] args)
    {
        var manager = new GoalManager();

        manager.AddGoal(new SimpleGoal("Run a marathon", 1000));
        manager.AddGoal(new EternalGoal("Read scriptures", 100));
        manager.AddGoal(new ChecklistGoal("Attend temple", 50, 10, 500));

        manager.ListGoals();

        Console.Write("Record which goal? ");
        int index = int.Parse(Console.ReadLine()) - 1;
        manager.RecordEvent(index);

        Console.WriteLine($"Total Score: {manager.ShowScore()}");
    }
}