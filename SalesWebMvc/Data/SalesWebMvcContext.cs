using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Models;
using SalesWebMvc.Models.ViewModels;

public class SalesWebMvcContext(DbContextOptions<SalesWebMvcContext> options) : DbContext(options)
{
    public DbSet<Department> Department { get; set; } = default!;
    public DbSet<Seller> Seller { get; set; }
    public DbSet<SalesRecord> SalesRecord { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SalesRecord>()
            .HasOne(s => s.Seller)
            .WithMany(s => s.Sales)
            .OnDelete(DeleteBehavior.Restrict);
    }
}