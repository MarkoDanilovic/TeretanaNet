using System.Reflection;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class StoreContext : DbContext
{
    public StoreContext(DbContextOptions<StoreContext> options) : base(options)
    {
    }

    public DbSet<Trener> Treneri { get; set; }
    public DbSet<Clan> Clanovi { get; set; }
    public DbSet<Trening> Treninzi { get; set; }
    public DbSet<IndividualniTrening> IndividualniTreninzi { get; set; }
    public DbSet<GrupniTrening> GrupniTreninzi { get; set; }
    public DbSet<Grupa> Grupe { get; set; }
    public DbSet<ClanGrupa> ClanGrupe { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        if (Database.ProviderName == "Microsoft.EntityFrameworkCore.Sqlite")
        {
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                var properties = entityType.ClrType.GetProperties().Where(p => p.PropertyType == typeof(decimal));

                foreach (var property in properties)
                {
                    modelBuilder.Entity(entityType.Name).Property(property.Name).HasConversion<double>();
                }
            }
        }
    }
}