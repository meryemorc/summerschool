using Microsoft.EntityFrameworkCore;
using yaz_okulu_backend.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    // 📌 Veritabanındaki tablo isimlerine uygun DbSet tanımları:
    public DbSet<User> users { get; set; }
    public DbSet<University> universities { get; set; }
    public DbSet<Faculty> faculties { get; set; }
    public DbSet<Department> departments { get; set; }
    public DbSet<Course> courses { get; set; }
    public DbSet<CourseEnrollment> course_enrollments { get; set; }
    public DbSet<Comment> comments { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // 📌 Tabloların isimlerini veritabanındaki isimlere uygun hale getiriyoruz.
        modelBuilder.Entity<User>().ToTable("users");
        modelBuilder.Entity<University>().ToTable("universities");
        modelBuilder.Entity<Faculty>().ToTable("faculties");
        modelBuilder.Entity<Department>().ToTable("departments");
        modelBuilder.Entity<Course>().ToTable("courses");
        modelBuilder.Entity<CourseEnrollment>().ToTable("course_enrollments");
        modelBuilder.Entity<Comment>().ToTable("comments");
    }
}
