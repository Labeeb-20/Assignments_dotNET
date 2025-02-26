namespace EmployeesWebAPI.Models
{
    public interface IEmployeeDataAccess
    {
        void AddEmployee(Employee employee);
        void DeleteEmployee(int id);
        void UpdateEmployee(Employee employee);
        List<Employee> GetAllEmployees();
        Employee GetEmployee(int id);
    }
}
