using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Program 3: Inheritance with Event Planning");
        Console.WriteLine();
        
        // Lecture Event
        Address eventAddress1 = new Address("123 Main St", "Houston", "Texas", "USA");
        LecturesEvent lecturesEvent = new LecturesEvent(
            title: "Exploring Moby-Dick",
            description: "An in-depth analysis of the classic novel Moby-Dick",
            date: "2023-12-15",
            time: "18:00",
            address: eventAddress1,
            name: "Professor Oaks", // Speaker's name
            capacity: 100 // Maximum capacity for the lecture event
        );

        Console.WriteLine("1. Lecture Event");
        Console.WriteLine();
        Console.WriteLine("Standard details:");
        Console.WriteLine(lecturesEvent.CreateStandardDetails());
        Console.WriteLine();
        Console.WriteLine("Full details:");
        Console.WriteLine(lecturesEvent.CreateteFullDetailsLecture());
        Console.WriteLine();
        Console.WriteLine("Short description:");
        Console.WriteLine(lecturesEvent.CreateShortDescription());

        // Reception Event
        Address eventAddress2 = new Address("456 Oak St", "Townsville", "California", "USA");
        ReceptionEvent receptionEvent = new ReceptionEvent(
            title: "Grand Opening Reception",
            description: "Join us for the grand opening of our new office",
            date: "2023-12-10",
            time: "18:00",
            address: eventAddress2,
            email: "info@greception.com" // Contact email for the event
        );

        Console.WriteLine("2. Reception Event");
        Console.WriteLine();
        Console.WriteLine("Standard details:");
        Console.WriteLine(receptionEvent.CreateStandardDetails());
        Console.WriteLine();
        Console.WriteLine("Full details:");
        Console.WriteLine(receptionEvent.CreateFullDetailsReception());
        Console.WriteLine();
        Console.WriteLine("Short description:");
        Console.WriteLine(receptionEvent.CreateShortDescription());

        // Outdoor Gathering
        Address eventAddress3 = new Address("789 Pine St", "American Fork", "Utah", "USA");
        OutdoorEvent outdoorEvent = new OutdoorEvent(
            title: "Summer Music Festival",
            description: "Enjoy live music outdoors under the stars",
            date: "2023-07-15",
            time: "20:00",
            address: eventAddress3,
            weather: "Clear Skies" // Weather condition for the outdoor event
        );

        Console.WriteLine("3. Outdoor Gathering Event");
        Console.WriteLine();
        Console.WriteLine("Standard details:");
        Console.WriteLine(outdoorEvent.CreateStandardDetails());
        Console.WriteLine();
        Console.WriteLine("Full details:");
        Console.WriteLine(outdoorEvent.CreateFullDetailsOutdoors());
        Console.WriteLine();
        Console.WriteLine("Short description:");
        Console.WriteLine(outdoorEvent.CreateShortDescription());
    }
}