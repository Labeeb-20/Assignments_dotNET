namespace CollectionAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            products.Add(new Product(200, "Dell", "15 inch Monitor", 3400.44));
            products.Add(new Product(120, "Dell", "Laptop", 45000.00));
            products.Add(new Product(150, "Microsoft", "Windows 7", 7000.50));
            products.Add(new Product(100, "Logitech", "Optical Mouse", 540.00));
            products.Sort();

            Console.WriteLine("Enter the option to sort:\n1. Brand Name\n2.Price");
            int choice = int.Parse(Console.ReadLine());
            

            switch (choice)
            {
                case 1:
                    products.Sort(new SortByBrand());
                    break;
                case 2:
                    products.Sort(new SortByPrice());
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }

            foreach (Product product in products)
            {
                Console.WriteLine(product.ToString());
                Console.WriteLine("===================");
            }
        }
    }

    class Product : IComparable<Product>
    {
        public int prodID { get; set; }
        public string brand { get; set; }
        public string description { get; set; }
        public double price { get; set; }

        public Product(int prodID, string brand, string description, double price)
        {
            this.prodID = prodID;
            this.brand = brand;
            this.description = description;
            this.price = price;
        }

        public override string ToString()
        {
            return $"Product Id: {prodID}\nBrand Name: {brand}\nDescription: {description}\nPrice:{price}";
        }

        public int CompareTo(Product? other)
        {
            if (this.prodID > other.prodID)
            {
                return 1;
            }
            else if (this.prodID < other.prodID)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }

    class SortByBrand : IComparer<Product>
    {
        int IComparer<Product>.Compare(Product? x, Product? y)
        {
            if ((x.brand.CompareTo(y.brand) == 1))
            {
                return 1;
            }
            else if ((x.brand.CompareTo(y.brand) == 1))
            {
                return -1;
            }
            else
            {
                if (x.description.CompareTo(y.description) == 1)
                {
                    return 1;
                }
                else if (x.description.CompareTo(y.description) == -1)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }

            }
        }
    }

    class SortByPrice : IComparer<Product>
    {
        int IComparer<Product>.Compare(Product? x, Product? y)
        {
            if ((x.price < y.price))
            {
                return 1;
            }
            else if ((x.price > y.price))
            {
                return -1;
            }
            else
            {
                if (x.prodID < y.prodID)
                {
                    return 1;
                }
                else if (x.prodID > y.prodID)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }

            }
        }
    }
}
