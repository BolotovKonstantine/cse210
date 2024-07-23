using System;

class Program
{
    static void Main(string[] args)
    {
        var lectureEvent = new Lecture(
            title: "Python 101",
            description: "An introductory lecture on Python programming",
            date: "2024-09-12",
            time: "15:00",
            address: new Address(street: "123 Main St", city: "Springfield", state: "IL", country: "USA"),
            speaker: "John Doe",
            topic: "Python Programming"
        );
        
        var receptionsEvent = new Receptions(
            title: "Welcome Reception",
            description: "A warm welcome for all new students",
            date: "2024-09-10",
            time: "18:00",
            address: new Address(street: "456 Market St", city: "Springfield", state: "IL", country: "USA"),
            host: "University XYZ",
            isFormal: true
        );

        var outdoorEvent = new Outdoor(
            title: "Homecoming Parade",
            description: "An exciting parade celebrating homecoming week",
            date: "2024-10-22",
            time: "10:00",
            address: new Address(street: "789 Park Ave", city: "Springfield", state: "IL", country: "USA"),
            location: "Downtown Park",
            weatherConditions: "Sunny"
        );

        Event[] events = {lectureEvent, receptionsEvent, outdoorEvent};

        foreach(Event e in events){
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine(e.DisplayStdDetails());
            Console.WriteLine();
            Console.WriteLine(e.ShortDescription());
            Console.WriteLine("----------------------------------------------------");
            if (e is Lecture)
            {
                Console.WriteLine(((Lecture)e).DisplayFullDetails());
            }
            else if (e is Receptions)
            {
                Console.WriteLine(((Receptions)e).DisplayFullDetails());
            }
            else if (e is Outdoor)
            {
                Console.WriteLine(((Outdoor)e).DisplayFullDetails());
            }
        }
    }
}