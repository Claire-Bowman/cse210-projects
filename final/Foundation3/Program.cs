using System;

public class Program
{
    public static void Main()
    {
        Address addr1 = new Address("123 Event Blvd", "New York", "NY", "USA");
        Address addr2 = new Address("500 Beach Rd", "Santa Monica", "CA", "USA");
        Address addr3 = new Address("42 Castle St", "Edinburgh", "Scotland", "UK");

        Event lecture = new Lecture("Tech Talk", "AI in 2025", "August 12", "2:00 PM", addr1, "Dr. Jane Doe", 150);
        Event reception = new Reception("Networking Mixer", "Meet local professionals", "August 15", "6:00 PM", addr2, "rsvp@events.com");
        Event outdoor = new OutdoorGathering("Summer Fest", "Live music and food trucks", "August 20", "4:00 PM", addr3, "Sunny with clear skies");

        DisplayEvent(lecture);
        DisplayEvent(reception);
        DisplayEvent(outdoor);
    }

    private static void DisplayEvent(Event e)
    {
        Console.WriteLine("----- Standard Details -----");
        Console.WriteLine(e.GetStandardDetails());
        Console.WriteLine("\n----- Full Details -----");
        Console.WriteLine(e.GetFullDetails());
        Console.WriteLine("\n----- Short Description -----");
        Console.WriteLine(e.GetShortDescription());
        Console.WriteLine(new string('-', 40));
    }
}