using RazorPages.Models;
using System.Linq;

namespace RazorPages.Repository
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

       
        public IEnumerable<Employee> GetAll()
        {
            return _employeeList;
        }

        public Employee GetById(int id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == id);
        }

        public Employee Update(Employee entitiy)
        {
            Employee employee = _employeeList.FirstOrDefault(e => e.Id == entitiy.Id);

            if(employee != null)
            {
                employee.Name = entitiy.Name;
                employee.Email = entitiy.Email;
                employee.Department = entitiy.Department;
                employee.Photo = entitiy.Photo;
            }

            return employee;
        }
    }
}
