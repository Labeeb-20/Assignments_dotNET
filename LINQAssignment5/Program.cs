using System.ComponentModel.DataAnnotations;

namespace LINQAssignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of halls: ");
            int noOfHall = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Hall details: ");
            string csv;
            List<Hall> hall = new List<Hall>();

            for (int i = 0; i < noOfHall; i++)
            {
                csv = Console.ReadLine();
                string[] halls = csv.Split(",");
                double cost = double.Parse(halls[halls.Length - 2]);
                string hallName = halls[0];
                string owner = halls[halls.Length - 1];

                hall.Add(new Hall(hallName, cost, owner));
            }

            hall.Sort();

            foreach (Hall hall1 in hall)
            {
                Console.WriteLine(hall1.ToString());
            }

        }
    }

    class Hall:IComparable<Hall>
    {
        public string name { get; set; }
        public double costPerDay { get; set; }
        public string owner { get; set; }

        public Hall(string name, double costPerDay, string owner)
        {
            this.name = name;
            this.costPerDay = costPerDay;
            this.owner = owner;
        }

        public override string ToString()
        {
            return $"{name}\t{costPerDay}\t{owner}";
        }

        public int CompareTo(Hall? other)
        {
            if (this.owner.CompareTo(other.owner) == 1)
            {
                return 1;
            }

            else if (this.owner.CompareTo(other.owner) == -1)
            {
                return -1;
            }
            else {
                return 0;    
            }
        }
    }
}
