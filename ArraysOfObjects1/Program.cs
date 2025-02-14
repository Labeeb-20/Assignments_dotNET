using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace ArraysOfObjects1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] emp = new Employee[5];
            emp[0] = new Employee(1, "Ravi", 1111, 201);
            emp[1] = new Employee(2, "Krish", 1122, 202);
            emp[2] = new Employee(3, "John", 2211, 201);
            emp[3] = new Employee(4, "Raman", 3115, 202);
            emp[4] = new Employee(5, "Rajiv", 4444, 203);
            double sum = 0;

            for (int i = 0; i < emp.Length; i++)
            {
                Console.WriteLine(emp[i].ToString());
                Console.WriteLine("==========================");
                sum += emp[i].salary;
            }
            Console.WriteLine("Total Salary: " + sum);



        }
    }

    class Employee
    {
        int ecode;
        string ename;
        public double salary { get; set; }
        int depid;


        public Employee(int ecode, string ename, float salary,  int depid)
        {
            this.ecode = ecode;
            this.ename = ename;
            this.salary = salary;
            this.depid = depid;
           
        }

        public override string ToString() {
            return $"Employee Id: {ecode}\nEmployee Name: {ename}\nSalary: {salary}\nDepid: {depid}";
        }
    }
}
