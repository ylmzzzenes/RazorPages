using RazorPages.Models;
using System.Linq;

namespace RazorPages.Repository
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee{Id =1, Name="Enes Yılmaz", Email="enesyilmaz.ey3@gmail.com", Photo="1.jpg", Department="Software"},
                new Employee{Id =2, Name="Yusuf Yılmaz", Email="Yusufyilmaz.ey3@gmail.com", Photo="2.jpg", Department="IT"},
                new Employee{Id =3, Name="Sultan Yılmaz", Email="Sultanyilmaz.ey3@gmail.com", Photo="3.jpg", Department="Hardware"},
                new Employee{Id =4, Name="Yasin Yılmaz", Email="yasinyilmaz.ey3@gmail.com", Photo="4.jpg", Department="ME"},
                new Employee{Id =5, Name="Esra Baysan", Email="EsraBaysan.ey3@gmail.com", Photo="5.jpg", Department="A"},
                new Employee{Id =6, Name="Bulut Baysan", Email="BulutBaysan.ey3@gmail.com", Photo="6.jpg", Department="s"},

            };
        }
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
