public class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, "Eternal", points) {}

    public override int RecordCompletion() => _pointsPerCompletion;

    public override bool IsCompleted() => false;

    public override object ToFirestore() => new
    {
        Id = _id,
        Name = _name,
        Type = _type,
        Points = _pointsPerCompletion
    };

    public static new EternalGoal FromFirestore(object data) => throw new NotImplementedException();
}