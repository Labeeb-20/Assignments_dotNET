namespace ExceptionAssignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the start date and time(dd/mm/yyyy hh:mm:ss tt): ");
                DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy hh:mm:ss tt", null);
                Console.WriteLine("Enter the end date and time(dd/mm/yyyy hh:mm:ss tt): ");
                DateTime date1 = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy hh:mm:ss tt", null);

                Console.WriteLine($"Start Date: {date}\nEnd Date: {date1}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
