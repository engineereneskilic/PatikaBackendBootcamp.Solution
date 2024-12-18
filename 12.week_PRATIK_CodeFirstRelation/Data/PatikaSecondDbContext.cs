using _12.week_PRATIK_CodeFirstRelation.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace _12.week_PRATIK_CodeFirstRelation.Data
{
    public class PatikaSecondDbContext: DbContext
    {
        // Constructor injecting DbContext options.
        public PatikaSecondDbContext(DbContextOptions<PatikaSecondDbContext> options) : base(options) { }

        // DbSet for Users.
        public DbSet<User> Users { get; set; }

        // DbSet for Posts.
        public DbSet<Post> Posts { get; set; }

        /// <summary>
        /// Configures the relationships and entity mappings using Fluent API.
        /// </summary>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuring the one-to-many relationship between User and Post.
            modelBuilder.Entity<Post>()
                .HasOne(p => p.User)
                .WithMany(u => u.Posts)
                .HasForeignKey(p => p.UserId);
        }
    }
}
