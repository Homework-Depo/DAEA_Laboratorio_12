namespace Laboratorio13;

using Microsoft.EntityFrameworkCore;

public class SchoolContext : DbContext
{
    public SchoolContext(DbContextOptions<SchoolContext> options) : base(options) { }

    public DbSet<Course> Courses { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Grade> Grades { get; set; }
    public DbSet<Enrollment> Enrollments { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Course>().ToTable("Course");
        modelBuilder.Entity<Student>().ToTable("Student");
        modelBuilder.Entity<Grade>().ToTable("Grade");
        modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
    }
}
