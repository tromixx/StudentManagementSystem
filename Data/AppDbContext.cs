using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<Student> Students {get; set;}
    public DbSet<Course> Courses {get; set;}

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}
}
