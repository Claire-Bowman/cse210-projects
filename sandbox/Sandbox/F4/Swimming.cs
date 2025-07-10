public class Swimming : Activity
{
    private int _lapCount;

    public Swimming(string date, int durationMinutes, int lapCount)
        : base(date, durationMinutes)
    {
        _lapCount = lapCount;
    }

    public override double GetDistance()
    {
        return (_lapCount * 50) / 1000.0 * 0.62; // meters to miles
    }

    public override double GetSpeed()
    {
        return (GetDistance() / DurationMinutes) * 60;
    }

    public override double GetPace()
    {
        return DurationMinutes / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{Date} Swimming ({DurationMinutes} min): Distance {GetDistance():0.0} miles, Speed {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}