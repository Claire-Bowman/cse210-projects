using System;

public class Activity
{
    private string _date;
    private int _durationMinutes;

    public Activity(string date, int durationMinutes)
    {
        _date = date;
        _durationMinutes = durationMinutes;
    }

    public string Date => _date;
    public int DurationMinutes => _durationMinutes;

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return $"{_date} Activity ({_durationMinutes} min)";
    }
}