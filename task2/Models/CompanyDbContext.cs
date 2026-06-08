using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace task2.Models
{
    public class CompanyDbContext : DbContext
    {
        public CompanyDbContext() { }

        public CompanyDbContext(DbContextOptions<CompanyDbContext> options) : base(options) { }

        public DbSet<Department> Departments { get; set; }
        public DbSet<instructor> Instructors { get; set; }
        public DbSet<Trainee> Trainees { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<crsResult> CrsResults { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=MAHMOUD\\SQLEXPRESS; Initial Catalog = Company_gis; Integrated Security = True; Trust Server Certificate = True;");
                
            }
        }
    }
}

    

