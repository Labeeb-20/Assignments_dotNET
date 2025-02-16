namespace ArrayOfObjects2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of customers: ");
            int n = int.Parse(Console.ReadLine());

            Customer[] customers = new Customer[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter details for Customer {i + 1}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Mobile Number: ");
                string mobileNumber = Console.ReadLine();
                Console.Write("Feedback Rating (out of 5): ");
                double feedbackRating = double.Parse(Console.ReadLine());

                customers[i] = new Customer(feedbackRating, mobileNumber, name);
            }

            double totalFeedback = 0;
            foreach (Customer customer in customers)
            {
                totalFeedback += customer.FeedbackRating;
            }

            double averageFeedback = totalFeedback / customers.Length;
            Console.WriteLine();
            Console.WriteLine("Average Feedback Rating: " + averageFeedback);
        }
    }

    class Customer
    {
        public double FeedbackRating { get; set; }
        public string MobileNumber { get; set; }
        public string Name { get; set; }

        public Customer(double feedbackRating, string mobileNumber, string name)
        {
            FeedbackRating = feedbackRating;
            MobileNumber = mobileNumber;
            Name = name;
        }
    }

}
