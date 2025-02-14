namespace ExceptionAssignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the booking details");
                string booking = Console.ReadLine();
                Console.WriteLine("Enter the seat number to book");
                int seat = int.Parse(Console.ReadLine());

                if (booking[seat - 1].Equals('0'))
                {
                    Console.WriteLine("Booked Successfully");
                }
                else
                {
                    throw new SeatNotAvailableException("Seat already booked");
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (SeatNotAvailableException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    class SeatNotAvailableException : Exception
    {
        public SeatNotAvailableException(string errmsg) : base(errmsg)
        {
            
        }
    }
}
