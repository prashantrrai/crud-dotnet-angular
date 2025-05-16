using CRUD_BE.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_BE.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }


        // DbSet Properties.
        public DbSet<Employee> Employees { get; set; }
    }
}
