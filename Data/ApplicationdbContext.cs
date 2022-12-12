using TrinhQuangMinhBTH2.Models;
using Microsoft.EntityFrameworkCore;
namespace TrinhQuangMinhBTH2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Faculty> Faculties { get; set; } = default!;


    }
}