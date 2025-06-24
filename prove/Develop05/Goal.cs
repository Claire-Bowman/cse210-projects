using System;

public abstract class Goal
{
    protected string _id;
    protected string _name;
    protected string _type;
    protected int _pointsPerCompletion;
    protected string _createdAt;

    public Goal(string name, string type, int pointsPerCompletion)
    {
        _id = Guid.NewGuid().ToString();
        _name = name;
        _type = type;
        _pointsPerCompletion = pointsPerCompletion;
        _createdAt = DateTime.Now.ToString();
    }

    public abstract int RecordCompletion();
    public abstract bool IsCompleted();
    public virtual string GetDisplayProgress() => "[ ]";
    public abstract object ToFirestore();
    public static Goal FromFirestore(object data) => throw new NotImplementedException();
}