public class Running : Activity
{
    private double _distanceMiles;

    public Running(string date, int durationMinutes, double distanceMiles)
        : base(date, durationMinutes)
    {
        _distanceMiles = distanceMiles;
    }

    public override double GetDistance()
    {
        return _distanceMiles;
    }

    public override double GetSpeed()
    {
        return (_distanceMiles / DurationMinutes) * 60;
    }

    public override double GetPace()
    {
        return DurationMinutes / _distanceMiles;
    }

    public override string GetSummary()
    {
        return $"{Date} Running ({DurationMinutes} min): Distance {GetDistance():0.0} miles, Speed {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}