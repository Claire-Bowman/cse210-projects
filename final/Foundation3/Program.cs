using System;

class Program
{
    static void Main(string[] args)
    {
        // Address shared template
        Address address1 = new Address("123 Event Blvd", "New York", "NY", "USA");
        Address address2 = new Address("500 Beach Rd", "Santa Monica", "CA", "USA");
        Address address3 = new Address("42 Castle St", "Edinburgh", "Scotland", "UK");

        // Create events
        Event lecture = new Lecture("Tech Talk", "AI in 2025", "August 12", "2:00 PM", address1, "Dr. Jane Doe", 150);
        Event reception = new Reception("Networking Mixer", "Meet local professionals", "August 15", "6:00 PM", address2, "rsvp@events.com");
        Event outdoor = new OutdoorGathering("Summer Fest", "Live music and food trucks", "August 20", "4:00 PM", address3, "Sunny with clear skies");

        // Display marketing messages
        DisplayEventMessages(lecture);
        DisplayEventMessages(reception);
        DisplayEventMessages(outdoor);
    }

    static void DisplayEventMessages(Event e)
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