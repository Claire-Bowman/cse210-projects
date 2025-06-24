using System;
using System.Collections.Generic;

public class GoalManager
{
    private List<Goal> _goals = new();
    private int _score = 0;

    public void AddGoal(Goal goal) => _goals.Add(goal);

    public void ListGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            var goal = _goals[i];
            Console.WriteLine($"{i + 1}. {goal.GetDisplayProgress()} {goal.GetType().Name} - {goal}");
        }
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            int points = _goals[goalIndex].RecordCompletion();
            _score += points;
            Console.WriteLine($"Recorded! You earned {points} points.");
        }
    }

    public int ShowScore() => _score;

    public void SaveToFile(string filename) => throw new NotImplementedException();
    public void LoadFromFile(string filename) => throw new NotImplementedException();
}