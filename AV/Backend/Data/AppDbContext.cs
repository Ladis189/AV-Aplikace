using Microsoft.EntityFrameworkCore;
using Shared;

namespace Backend.Data;

public class AppDbContext :  DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Uzivatel> Uzivatele { get; set; }
    public DbSet<Karta> Karty { get; set; }
    public DbSet<Pobocka> Pobocky { get; set; }
    public DbSet<Benefit> Benefity { get; set; }
    public DbSet<Navsteva> Navstevy { get; set; }
    public DbSet<OblibenyBenefit> Oblibene_benefity { get; set; }
    public DbSet<Novinka> Novinky { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // EF Core musí vědět, že primární klíč se skládá ze dvou sloupců
        modelBuilder.Entity<OblibenyBenefit>()
            .HasKey(ob => new { ob.Uzivatel_id, ob.Benefit_id });
    }
}


