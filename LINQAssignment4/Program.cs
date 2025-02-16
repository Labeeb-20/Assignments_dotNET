using System.Collections.Specialized;
using System.Runtime.CompilerServices;

namespace LINQAssignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of events: ");
            int noOfEvents = int.Parse(Console.ReadLine());
            string csv;
            List<Event> ev = new List<Event>();
            Console.WriteLine("Enter the events details: ");

            for (int i = 0; i < noOfEvents; i++) { 
                csv = Console.ReadLine();
                string[] events = csv.Split(",");
                double cost = double.Parse(events[events.Length - 1]);
                string eventName = events[0];
                string organizerName = events[1];
                ev.Add(new Event(eventName, organizerName, cost));   
            }

            Event.Display(ev);
        }
    }

    class Event
    {
        public string eventName { get; set; }
        public string organiserName { get; set; }
        public double eventCost { get; set; }

        public Event(string eventName, string organiserName, double eventCost)
        {
            this.eventName = eventName;
            this.organiserName = organiserName;
            this.eventCost = eventCost;
        }

        public override string ToString()
        {
            return $"{eventName}|{organiserName}|{eventCost}";
        }

        public static void Display(List<Event> events)
        {
            events.ForEach(eventItem => Console.WriteLine(eventItem.ToString()));
        }
    }
    }
