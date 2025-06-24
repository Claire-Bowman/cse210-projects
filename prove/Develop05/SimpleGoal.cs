public class SimpleGoal : Goal
{
    private bool _completed;

    public SimpleGoal(string name, int points) : base(name, "Simple", points)
    {
        _completed = false;
    }

    public override int RecordCompletion()
    {
        if (!_completed)
        {
            _completed = true;
            return _pointsPerCompletion;
        }
        return 0;
    }

    public override bool IsCompleted() => _completed;

    public override string GetDisplayProgress() => _completed ? "[X]" : "[ ]";

    public override object ToFirestore() => new
    {
        Id = _id,
        Name = _name,
        Type = _type,
        Points = _pointsPerCompletion,
        Completed = _completed
    };

    public static new SimpleGoal FromFirestore(object data) => throw new NotImplementedException();
}