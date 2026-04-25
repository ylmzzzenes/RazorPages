using Microsoft.EntityFrameworkCore;

namespace RazorPages.Models
{
    public class DataContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Database=RazorDb; Trusted_Connection=True; TrustServerCertificate = True;");
        }
    }
}
