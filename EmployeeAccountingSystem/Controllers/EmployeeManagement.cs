
namespace EmployeeAccountingSystem.Controllers
{
    public class EmployeeManagement
    {
        private readonly List<Employee> _employees = new();

        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
        }

        public void RemoveEmployee(int id)
        {
            _employees.RemoveAll(e => e.ID == id);
        }

        public List<Employee> GetAllEmployees()
        {
            return _employees;
        }
    }

}
