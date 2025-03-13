using Microsoft.EntityFrameworkCore;
using SistemaVivero.Models;

namespace SistemaVivero.Data;

public class ApplicationDbContext : DbContext 
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Productor> Productores { get; set; }
    public DbSet<Finca> Fincas { get; set; }
    public DbSet<Vivero> Viveros { get; set; }
    public DbSet<Labor> Labores { get; set; }
    public DbSet<ProductoControl> Productos { get; set; }
    public DbSet<ProductoControlHongo> ProductosControlHongo { get; set; }
    public DbSet<ProductoControlPlaga> ProductosControlPlaga { get; set; }
    public DbSet<ProductoControlFertilizante> ProductosControlFertilizante { get; set; }



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Herencia: Configuracion para producto (TPH)
        modelBuilder.Entity<ProductoControl>()
            .HasDiscriminator<string>("TipoProducto")
            .HasValue<ProductoControlHongo>("HONGO")
            .HasValue<ProductoControlPlaga>("PLAGA")
            .HasValue<ProductoControlFertilizante>("FERTILIZANTE");

        // RELACIONES OPCIONALES POR CLARIDAD (NO ESTRICTAMENTE NECESARIAS POR CONVENCION EF)
        modelBuilder.Entity<Finca>()
            .HasOne(f => f.Productor)
            .WithMany(p => p.Fincas)
            .HasForeignKey(f => f.ProductorId);

        modelBuilder.Entity<Vivero>()
            .HasOne(v => v.Finca)
            .WithMany(f => f.Viveros)
            .HasForeignKey(v => v.FincaId);

        modelBuilder.Entity<Labor>()
               .HasOne(l => l.Vivero)
               .WithMany(v => v.Labores)
               .HasForeignKey(l => l.ViveroId);

        modelBuilder.Entity<ProductoControl>()
            .HasOne(p => p.Labor)
            .WithMany(l => l.Productos)
            .HasForeignKey(p => p.LaborId)
            .OnDelete(DeleteBehavior.Restrict); // PARA EVITAR CASCADAS


    }
}
