using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running("03 Nov 2022", 30, 3.0));
        activities.Add(new Cycling("03 Nov 2022", 45, 15.0));
        activities.Add(new Swimming("03 Nov 2022", 40, 30));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}