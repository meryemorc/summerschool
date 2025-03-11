using Microsoft.EntityFrameworkCore;
using yaz_okulu_backend.Models;


public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    // Ders modelini kullanıyoruz
    public DbSet<Ders> ders { get; set; }  
}
