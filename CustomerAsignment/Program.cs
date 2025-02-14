namespace CustomerAsignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("1. Privilege Customer");
                Console.WriteLine("2. Senior Citizen Customer");
                Console.WriteLine("Enter the type of customer: ");
                int choice = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Age: ");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Address: ");
                string address = Console.ReadLine();
                Console.WriteLine("Enter Mobile Number: ");
                string mobileNumber = Console.ReadLine();
                Console.WriteLine("Enter the purchased Amount: ");
                double amount = double.Parse(Console.ReadLine());


                switch (choice)
                {
                    case 1:
                        PrivilegedCustomer pw = new PrivilegedCustomer(name, address, mobileNumber, age, amount);
                        double discountedAmount = Math.Round(pw.GenerateBillAmount(amount), 2);
                        pw.DisplayCustomer();
                        Console.WriteLine($"Your bill amount is Rs {Math.Round(amount, 1)}.Your bill amount is discount under privilege customer");
                        Console.WriteLine($"You have to bay Rs {discountedAmount}");
                        break;
                    case 2:
                        SeniorCitizenCustomer sc = new SeniorCitizenCustomer(name, address, mobileNumber, age, amount);
                        double discountAmount = Math.Round(sc.GenerateBillAmount(amount), 2);
                        sc.DisplayCustomer();
                        Console.WriteLine($"Your bill amount is Rs {Math.Round(amount, 1)}.Your bill amount is discount under privilege customer");
                        Console.WriteLine($"You have to bay Rs {discountAmount}");
                        break;

                    default:
                        Console.WriteLine("Invalid customer Type");
                        break;
                }
        }
    }

    class Customer
    {
        string name;
        string address;
        string mobileNumber;
        int age;

        public Customer(string name,  string address, string mobileNumber, int age)
        {
            this.name = name;
            this.address = address;
            this.mobileNumber = mobileNumber;
            this.age = age;
        }

        public void DisplayCustomer()
        {
            Console.WriteLine($"Name: {name}\nAddress: {address}\nMobile Number: {mobileNumber}\nAge: {age}");
        }
    }

    class PrivilegedCustomer:Customer
    {
        double amount;

        public PrivilegedCustomer(string name, string address, string mobileNumber, int age, double amount)
            : base(name, address, mobileNumber, age) { 
            this.amount = amount;
        }

        public double GenerateBillAmount(double amount)
        {
            double discount = amount - (amount * 0.30);
            return discount;
        }
    }

    class SeniorCitizenCustomer:Customer
    {
        double amount;

        public SeniorCitizenCustomer(string name, string address, string mobileNumber, int age, double amount)
            : base(name, address, mobileNumber, age)
        {
            this.amount = amount;
        }

        public double GenerateBillAmount(double amount)
        {
            double discount = amount - (amount * 0.12);
            return discount;
        }
    }
}
