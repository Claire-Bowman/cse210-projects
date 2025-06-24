public class ChecklistGoal : Goal
{
    private int _targetCompletions;
    private int _bonusPoints;
    private int _currentCompletions;

    public ChecklistGoal(string name, int points, int target, int bonus) 
        : base(name, "Checklist", points)
    {
        _targetCompletions = target;
        _bonusPoints = bonus;
        _currentCompletions = 0;
    }

    public override int RecordCompletion()
    {
        if (_currentCompletions < _targetCompletions)
        {
            _currentCompletions++;
            int total = _pointsPerCompletion;
            if (_currentCompletions == _targetCompletions)
                total += _bonusPoints;
            return total;
        }
        return 0;
    }

    public override bool IsCompleted() => _currentCompletions >= _targetCompletions;

    public override string GetDisplayProgress() => $"[{_currentCompletions}/{_targetCompletions}]";

    public override object ToFirestore() => new
    {
        Id = _id,
        Name = _name,
        Type = _type,
        Points = _pointsPerCompletion,
        Target = _targetCompletions,
        Bonus = _bonusPoints,
        Current = _currentCompletions
    };

    public static new ChecklistGoal FromFirestore(object data) => throw new NotImplementedException();
}