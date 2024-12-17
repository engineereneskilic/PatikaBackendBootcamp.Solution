using _12.week_Library_s02.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace _12.week_Library_s02.Data
{
    public class LibraryDbContext : DbContext
    {
        public  DbSet<Book> Books { get; set; }

        public DbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>(entity =>
                {
                    entity.ToTable("Books");
                    entity.HasKey(e => e.Id);
                    entity.Property(e => e.Title).IsRequired().HasMaxLength(100);
                    entity.Property(e => e.Author).IsRequired().HasMaxLength(50);
                    entity.Property(e => e.Price).HasColumnType("decimal(18,2)");
                    entity.Property(e => e.PublicationYear).HasColumnName("Year");
                    entity.HasIndex(e => e.Author);

                    entity.HasMany(e => e.Reviews)
                          .WithOne(e => e.Book)
                          .HasForeignKey(e => e.BookId)
                          .OnDelete(DeleteBehavior.Cascade); // kitap silinirse ona ait reviewlar gider


                });



            modelBuilder.Entity<Review>(entity =>
            {
                entity.ToTable("Reviews");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.ReviewerName).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Rating).HasColumnName("Stars");
            });
        }
    }
}
