
namespace EmployeesWebAPI.Models
{
    public class EmployeeDataAccess : IEmployeeDataAccess
    {
        private readonly EmployeeDBContext employeeDBContext;
        public EmployeeDataAccess(EmployeeDBContext employeeDBContext)
        {
            this.employeeDBContext = employeeDBContext;
        }
        public void AddEmployee(Employee employee)
        {
            employeeDBContext.Employees.Add(employee);
            employeeDBContext.SaveChanges();
        }

        public void DeleteEmployee(int id)
        {
            var record = employeeDBContext.Employees.Find(id);
            if (record != null)
            {
                employeeDBContext.Employees.Remove(record);
                employeeDBContext.SaveChanges();
            }
            else
            {
                throw new Exception("No Record Found");
            }
        }

        public List<Employee> GetAllEmployees()
        {
            return employeeDBContext.Employees.ToList();
        }

        public Employee GetEmployee(int id)
        {
            var record = employeeDBContext.Employees.Find(id);
            if(record != null)
            {
                return record;
            }
            else
            {
                throw new Exception("No Record Found");
            }
        }

        public void UpdateEmployee(Employee employee)
        {
            var record = employeeDBContext.Employees.Find(employee.Ecode);
            if (record != null)
            {
                record.Ename = employee.Ename;
                record.Salary = employee.Salary;
                record.Depid = employee.Depid;
                employeeDBContext.SaveChanges();
            }
            else
            {
                throw new Exception("No Record Found");
            }
        }
    }
}
