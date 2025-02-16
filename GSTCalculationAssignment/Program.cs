namespace GSTCalculationAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter event name: ");
            string name = Console.ReadLine();

            Console.Write("Enter the cost per day: ");
            double costPerDay = double.Parse(Console.ReadLine());

            Console.Write("Enter the number of days: ");
         
                int noOfDays = int.Parse(Console.ReadLine());

            Console.Write("Enter the type of event (1.Exhibition 2.Stage Event): ");
            int eventType = int.Parse(Console.ReadLine());

            Event eventObj;

            if (eventType == 1)
            {
                Console.Write("Enter the number of stalls: ");
                int noOfStalls = int.Parse(Console.ReadLine());
                eventObj = new Exhibition(name, "Exhibition", costPerDay, noOfDays, noOfStalls);
            }
            else
            {
                Console.Write("Enter the number of seats: ");
                int noOfSeats = int.Parse(Console.ReadLine());
                eventObj = new StageEvent(name, "Stage Event", costPerDay, noOfDays, noOfSeats);
            }

            Console.WriteLine("\nEvent Details");
            Console.WriteLine(eventObj.ToString());
        }
    }


    public class Event
    {
        protected string name;
        protected string type;
        protected double costPerDay;
        protected int noOfDays;

        public Event(string name, string type, double costPerDay, int noOfDays)
        {
            this.name = name;
            this.type = type;
            this.costPerDay = costPerDay;
            this.noOfDays = noOfDays;
        }

        public override string ToString()
        {
            return $"Name: {name}\nType: {type}\n";
        }
    }

    public class Exhibition : Event
    {
        private static int gst = 5;
        private int noOfStalls;

        public Exhibition(string name, string type, double costPerDay, int noOfDays, int noOfStalls)
            : base(name, type, costPerDay, noOfDays)
        {
            this.noOfStalls = noOfStalls;
        }

        public double TotalCost()
        {
            double totalCost = costPerDay * noOfDays;
            double gstAmount = totalCost * 0.05;
            return totalCost + gstAmount;
        }

        public override string ToString()
        {
            return base.ToString() + $"Number of stalls: {noOfStalls}\nTotal amount: {TotalCost()}";
        }
    }

    public class StageEvent : Event
    {
        private static int gst = 15;
        private int noOfSeats;

        public StageEvent(string name, string type, double costPerDay, int noOfDays, int noOfSeats)
            : base(name, type, costPerDay, noOfDays)
        {
            this.noOfSeats = noOfSeats;
        }

        public double TotalCost()
        {
            double totalCost = costPerDay * noOfDays;
            double gstAmount = totalCost * 0.15;
            return totalCost + gstAmount;
        }

        public override string ToString()
        {
            return base.ToString() + $"Number of seats: {noOfSeats}\nTotal amount: {TotalCost()}";
        }
    }
}
