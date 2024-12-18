using _12.week_PRATIK_CodeFirstBasic.Data.Entities;
using Microsoft.EntityFrameworkCore;

public class PatikaFirstDbContext: DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer($"");
    }

    public DbSet<Movie> Movies { get; set; } // Movie tablosu tanımı
    public DbSet<Game> Games { get; set; }   // Game tablosu tanımı

    public PatikaFirstDbContext(DbContextOptions<PatikaFirstDbContext> options)
           : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Tabloların yapılandırması
        modelBuilder.Entity<Movie>().ToTable("Movies");
        modelBuilder.Entity<Game>().ToTable("Games");

        base.OnModelCreating(modelBuilder);
    }

}
