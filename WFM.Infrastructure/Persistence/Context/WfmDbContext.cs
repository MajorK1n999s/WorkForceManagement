using Microsoft.EntityFrameworkCore;
using WFM.Domain.Entities;

namespace WFM.Infrastructure.Persistence.Context
{
    // DbContext =  bridge between C# classes and database tables 
    public class WfmDbContext : DbContext
    {
        public WfmDbContext(DbContextOptions<WfmDbContext> options) : base(options)
        {

        }

        // Tables
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeContact> EmployeeContacts { get; set; }
        public DbSet<TaskItem> Tasks { get; set; }
        public DbSet<Attendance> Attendances { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Apply all configurations automatically
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(WfmDbContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
