using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Models;
using RazorPages.Repository;

namespace RazorPages.Pages.Employees
{
    public class EditModel : PageModel
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EditModel(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        [BindProperty]
        public Employee Employee { get; set; }
        public void OnGet(int id)
        {
            Employee = _employeeRepository.GetById(id);
        }

        //public IActionResult OnPost(Employee employee)
        //{
        //    Employee  = _employeeRepository.Update(employee);
        //    return RedirectToPage("Index");
        //}

        public IActionResult OnPost()
        {
            Employee = _employeeRepository.Update(Employee);
            return RedirectToPage("Index");
        }
        }
}
