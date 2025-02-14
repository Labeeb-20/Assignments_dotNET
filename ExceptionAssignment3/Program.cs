using System.ComponentModel.Design;

namespace ExceptionAssignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ContactDetails co = new ContactDetails(987654321, 998765432, 08211234, "labeeb@gmail.com", "Mysore");
                ContactDetails co1 = new ContactDetails(987654321, 987654321, 08211234, "labeeb@gmail.com", "Mysore");
                ContactDetailsBO cbo = new ContactDetailsBO();

                cbo.Validate(co);
                cbo.Validate(co1);
            }
            catch (DuplicateNumberException ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }

    class ContactDetails
    {
        public long mobile { get; set; }
        public long alternateMobile { get; set; }
        public long landLine { get; set; }
        public string email { get; set; }
        public string address { get; set; }

        public ContactDetails(long mobile, long alternateMobile, long landLine, string email, string address)
        {
            this.mobile = mobile;
            this.alternateMobile = alternateMobile;
            this.landLine = landLine;
            this.email = email;
            this.address = address;
        }

        public override string ToString()
        {
            return $"Contact Details\nMobile Number: {mobile}\nAlternate Number: {alternateMobile}\nLandLine: {landLine}\nEmail: {email}\nAddress: {address}";
        }
    }

    class ContactDetailsBO
    {
        public void Validate(ContactDetails contactDetails)
        {
            if (contactDetails.mobile != contactDetails.alternateMobile)
                {
                    Console.WriteLine(contactDetails.ToString());
                }
            else
                {
                throw new DuplicateNumberException("Same Mobile Number and Alternate Mobile Number");
                }

            }
        }
    }

class DuplicateNumberException : Exception {
    public DuplicateNumberException(string err) : base(err) {
        
    }
}

