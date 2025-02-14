namespace LINQAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Books> books = new List<Books>
           {
               new Books("ASPNA", "ASP.NET Professional", "Wrox", "Bill Evjen, Matt Gibbs", 750.00),
               new Books("ASPNB", "Beginning ASP.NET", "TechMedia", "Dan Wahlin, Dave Reed", 545.00),
               new Books("LNQA", "Learning LINQ", "APress", "Steve Eichert", 400.00),
               new Books("CSPN", "C# Developers Guide", "Tata McGraw", "Dan Maharry", 675.00)

           };

            Console.WriteLine("Enter the book code to  be searched: ");
            string searchBook = (Console.ReadLine()).ToUpper();

            var res1 = from book in books
                       where book.Bcode == searchBook
                       select book;

            if (res1.Count() != 0)
            {

                foreach (var b in res1)
                {
                    Console.WriteLine($"Book Code: {b.Bcode}\nBook Name: {b.Bname}\nPublisher: {b.publisher}\nAuthor: {b.author}\nPrice: {b.price}");
                }
            }

            else
            {
                Console.WriteLine($"The book with id {searchBook} is not present");
            }

            Console.WriteLine("===================================================================================");

            Console.WriteLine("Enter the start range: ");
            double start = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the end range: ");
            double end = double.Parse(Console.ReadLine());

            var res2 = from book in books
                       where book.price > start && book.price < end
                       select book;
            if (res2.Count() != 0)
            {
                foreach (var b in res2)
                {
                    Console.WriteLine($"Book Code: {b.Bcode}\nBook Name: {b.Bname}\nPublisher: {b.publisher}\nAuthor: {b.author}\nPrice: {b.price}");
                    Console.WriteLine("------------------------------------------------------");
                }
            }
            else
            {
                Console.WriteLine("No books in the given range");
            }
        }
    }

    class Books
    {
        public string Bcode { get; set; }
        public string Bname { get; set; }
        public string publisher { get; set; }
        public string author { get; set; }
        public double price { get; set; }

        public Books(string Bcode, string Bname, string publisher, string author, double price)
        {
            this.Bcode = Bcode;
            this.Bname = Bname;
            this.publisher = publisher;
            this.author = author;
            this.price = price;
        }
    }
}
