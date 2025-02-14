namespace AccountDetailsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the Holder Name: ");
            string holderName = Console.ReadLine();
            Console.WriteLine("Enter your Account number: ");
            long accNo = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter the IFSC Code: ");
            string IFSCCode = Console.ReadLine();
            Console.WriteLine("Enter the Contact Number: ");
            long contactNumber = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter the type of Account: ");
            string choice = Console.ReadLine();


            switch (choice)
            {
                case "saving":
                    Console.WriteLine("Enter the intretst rate");
                    double intrestRate = double.Parse(Console.ReadLine());
                    SavingAccount sa = new SavingAccount(holderName, accNo, IFSCCode, contactNumber, intrestRate);
                    sa.DisplayDetails();
                    break;
                case "current":
                    Console.WriteLine("Enter the organization name: ");
                    string organizationName = Console.ReadLine();
                    Console.WriteLine("Enter TIN number: ");
                    long TIN = long.Parse(Console.ReadLine());
                    CurrentAccount ca = new CurrentAccount(holderName, accNo, IFSCCode, contactNumber, organizationName, TIN);
                    ca.DisplayDetails();
                    break;

                default:
                    Console.WriteLine("Invalid Account Type");
                    break;
            }
        }
    }
    class Account
    {
        string holderName;
        long accNo;
        string IFSCCode;
        long contactNumber;

        public Account(string holderName, long accNo, string IFSCCode, long contactNumber)
        {
            this.holderName = holderName;
            this.accNo = accNo;
            this.IFSCCode = IFSCCode;
            this.contactNumber = contactNumber;
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine("Your Contact Details");
            Console.WriteLine($"Holder Name: {holderName}\nAccount Number: {accNo}\nIFSC Code: {IFSCCode}\nContact Number: {contactNumber}");
        }
    }

    class SavingAccount : Account
    {
        double intrestRate;

        public SavingAccount(string holderName, long accNo, string IFSCCode, long contactNumber, double interstRate)
            : base(holderName, accNo, IFSCCode, contactNumber)
        {
            this.intrestRate = interstRate;
        }

       public override void DisplayDetails()
        {
            base.DisplayDetails();  
            Console.WriteLine("Intrest Rate: " + this.intrestRate);
        }
    }

    class CurrentAccount : Account
    {
        string organizationName;
        long TIN;

        public CurrentAccount(string holderName, long accNo, string IFSCCode, long contactNumber, string organizationName, long TIN)
            : base(holderName, accNo, IFSCCode, contactNumber)
        {
            this.organizationName = organizationName;
            this.TIN = TIN;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Organization Name: {organizationName}\nTIN: {TIN}");
        }
    }
}
