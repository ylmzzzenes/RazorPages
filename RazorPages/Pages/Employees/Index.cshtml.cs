using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPages.Pages.Employees
{
    public class IndexModel : PageModel
    {
        public string Message { get; set; } = string.Empty;
        public void OnGet()
        {
            Message = "ASP.NET Razor pages ";
        }
    }
}
