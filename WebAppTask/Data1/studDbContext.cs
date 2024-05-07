using Microsoft.EntityFrameworkCore;
using WebAppTask.Models;

namespace WebAppTask.Data1
{
    public class studDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=student;trusted_connection=true;trustservercertificate=true;");
        }

    }
}
