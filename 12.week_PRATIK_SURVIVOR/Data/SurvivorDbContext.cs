using _12.week_PRATIK_SURVIVOR.Models;
using Microsoft.EntityFrameworkCore;

namespace _12.week_PRATIK_SURVIVOR.Data
{
    public class SurvivorDbContext : DbContext
    {
        public SurvivorDbContext(DbContextOptions<SurvivorDbContext> options) : base(options) { }

        public DbSet<Competitor> Competitors { get; set; }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Kategori ve Yarışmacılar arasındaki ilişki
            modelBuilder.Entity<Category>()
                .HasMany(c => c.Competitors) // bir kategorinin birden fazla yarışmacısı olur
                .WithOne(c => c.Category) // bir yarışmacının bir kategorisi olur
                .HasForeignKey(c => c.CategoryId); //

            // Örnek veriler
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Ünlüler", CreatedDate = DateTime.UtcNow },
                new Category { Id = 2, Name = "Gönüllüler", CreatedDate = DateTime.UtcNow }
            );

            modelBuilder.Entity<Competitor>().HasData(
                new Competitor { Id = 1, FirstName = "Acun", LastName = "Ilıcalı", CategoryId = 1, CreatedDate = DateTime.UtcNow },
                new Competitor { Id = 2, FirstName = "Aleyna", LastName = "Avcı", CategoryId = 1, CreatedDate = DateTime.UtcNow },
                new Competitor { Id = 3, FirstName = "Ahmet", LastName = "Yılmaz", CategoryId = 2, CreatedDate = DateTime.UtcNow },
                new Competitor { Id = 4, FirstName = "Ayşe", LastName = "Kara", CategoryId = 2, CreatedDate = DateTime.UtcNow },
                new Competitor { Id = 5, FirstName = "Mehmet", LastName = "Demir", CategoryId = 1, CreatedDate = DateTime.UtcNow }
            );
        }
    }
}
