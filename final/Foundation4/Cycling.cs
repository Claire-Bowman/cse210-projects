public class Cycling : Activity
{
    private double _speedMph;

    public Cycling(string date, int durationMinutes, double speedMph)
        : base(date, durationMinutes)
    {
        _speedMph = speedMph;
    }

    public override double GetSpeed()
    {
        return _speedMph;
    }

    public override double GetDistance()
    {
        return (_speedMph * DurationMinutes) / 60;
    }

    public override double GetPace()
    {
        return 60 / _speedMph;
    }

    public override string GetSummary()
    {
        return $"{Date} Cycling ({DurationMinutes} min): Distance {GetDistance():0.0} miles, Speed {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}