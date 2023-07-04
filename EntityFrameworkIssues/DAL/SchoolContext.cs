using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using EntityFrameworkIssues.Models;

namespace EntityFrameworkIssues.DAL;

public class SchoolContext : DbContext
{
    
    public SchoolContext() : base("SchoolContext")
    {
    }
        
    public DbSet<Student> Students { get; set; }
    public DbSet<Enrollment> Enrollments { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
    }
}