using RazorPages.Models;

namespace RazorPages.Repository
{
    public class SqlEmployeeRepository : IEmployeeRepository
    {
        private readonly DataContext _context;

        public SqlEmployeeRepository(DataContext context)
        {
            _context = context;
        }
        public IEnumerable<Employee> GetAll()
        {
            return _context.Employees;
        }

        public Employee GetById(int id)
        {
            return _context.Employees.FirstOrDefault(e => e.Id == id);
        }

        public Employee Update(Employee entitiy)
        {
            var entitiyToUpdate = _context.Employees.FirstOrDefault(e => e.Id == entitiy.Id);

            if(entitiyToUpdate != null)
            {
                entitiyToUpdate.Name = entitiy.Name;
                entitiyToUpdate.Email = entitiy.Email;
                entitiyToUpdate.Department = entitiy.Department;
                entitiyToUpdate.Photo = entitiy.Photo;
                _context.SaveChanges();
            }
            return entitiyToUpdate;
        }
    }
}
