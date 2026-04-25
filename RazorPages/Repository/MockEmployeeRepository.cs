using RazorPages.Models;

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
                new Employee{Id =1, Name="Yusuf Yılmaz", Email="Yusufyilmaz.ey3@gmail.com", Photo="2.jpg", Department="IT"},
                new Employee{Id =1, Name="Sultan Yılmaz", Email="Sultanyilmaz.ey3@gmail.com", Photo="3.jpg", Department="Hardware"},
                new Employee{Id =1, Name="Yasin Yılmaz", Email="yasinyilmaz.ey3@gmail.com", Photo="4.jpg", Department="ME"},
                new Employee{Id =1, Name="Esra Baysan", Email="EsraBaysan.ey3@gmail.com", Photo="5.jpg", Department="A"},
                new Employee{Id =1, Name="Bulut Baysan", Email="BulutBaysan.ey3@gmail.com", Photo="6.jpg", Department="s"},

            };
        }
        public IEnumerable<Employee> GetAll()
        {
            return _employeeList;
        }
    }
}
