namespace LINQAssignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Course> cs = new List<Course>();
            Console.WriteLine("Enter the number of Courses: ");
            int NoOfCourse = int.Parse(Console.ReadLine());
            for (int i = 0; i < NoOfCourse; i++)
            {
                Console.WriteLine($"Course {i + 1} Details ");
                Console.WriteLine("Enter the Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the category: ");
                string category = Console.ReadLine();
                Console.WriteLine("Enter the price: ");
                int price = int.Parse(Console.ReadLine());

                cs.Add(new Course(id, name, category, price));
            }

            Console.WriteLine("Enter the Price Limit: ");
            Console.WriteLine();
            Console.WriteLine("Enter the Minimum Limit: ");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Maximum Limit: ");
            int max = int.Parse(Console.ReadLine());

            var result = from e in cs
                         where e.price > min && e.price < max
                         select e;
            int c = 1;

            if (result.Count() != 0)
            {
                Console.WriteLine($"Courses which is in limit {min} to {max}: ");
                Console.WriteLine();
                foreach (var r in result)
                {
                    Console.WriteLine($"Course {c} Details: ");
                    Console.WriteLine($"Course ID: {r.id}\nCourse name: {r.name}\nCourse Category: {r.category}\nCousre Price: {r.price}");
                    Console.WriteLine("===================================================");
                    c++;
                }
            }
            else
            {
                Console.WriteLine("No Courses available in this limit");
            }


        }
    }

    class Course
    {
        public int id { get; set; }
        public string name { get; set; }
        public string category { get; set; }
        public int price { get; set; }

        public Course(int id, string name, string category, int price)
        {
            this.id = id;
            this.name = name;
            this.category = category;
            this.price = price;
        }
    }
}
