using RazorPages.Models;

namespace RazorPages.Repository
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll();
        Employee GetById(int id);
    }
}
