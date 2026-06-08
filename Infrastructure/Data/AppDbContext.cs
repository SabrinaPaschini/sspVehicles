using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Vehicles> Vehicles { get; set; }
    public DbSet<Customers> Customers { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer("Server=localhost;Database=sspVehicles;Trusted_Connection=True;TrustServerCertificate=True;");
    }
}