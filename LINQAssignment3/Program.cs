namespace LINQAssignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<PlacedStudent> ps = new List<PlacedStudent>();
            Console.WriteLine("Enter number of companies: ");
            int noOfCompanies = int.Parse(Console.ReadLine());

            for (int i = 1; i <= noOfCompanies; i++)
            {
                Console.WriteLine("Enter Company Name: ");
                string CompName = Console.ReadLine();
                Console.WriteLine("Enter Student Name: ");
                string StudName = Console.ReadLine();

                ps.Add(new PlacedStudent(CompName, StudName));
            }

            var result = from placed in ps
                         group placed by placed.companyName into p
                         select p;

            Console.WriteLine();
            foreach (var group in result)
            {
                Console.WriteLine($"Company Name: {group.Key}");
                foreach (var person in group)
                {
                    Console.WriteLine($"{person.studentName}");
                }
            }

                         
                         
        }
    }

    class PlacedStudent
    {
        public string companyName { get; set; }
        public string studentName { get; set; }

        public PlacedStudent(string companyName, string studentName)
        {
            this.companyName = companyName;
            this.studentName = studentName;
        }
    }
}
