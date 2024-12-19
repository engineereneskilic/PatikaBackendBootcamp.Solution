using _12.week_MigrationsinCodeFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace _12.week_MigrationsinCodeFirst.Data
{
    public class EduPlatformContext : DbContext
    {
        public EduPlatformContext(DbContextOptions<EduPlatformContext> options): base(options)
        {
            
        }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Instructor> Instructors { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<Enrollment> Enrollments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>()
                        .HasOne(c => c.Instructor) // bir **kursu bir eğitmen verebilir
                        .WithMany(i => i.Courses) // bir egitmen birden fazla **course verebilir
                        .HasForeignKey(c => c.InstructorId);

            modelBuilder.Entity<Enrollment>()
                        .HasOne(e => e.Student)// Enrollement'da bir student olabilir
                        .WithMany(s => s.Enrollments)
                        .HasForeignKey(e => e.StudentId);

            modelBuilder.Entity<Enrollment>()
                        .HasOne(e => e.Course)
                        .WithMany(c => c.Enrollments)
                        .HasForeignKey(e => e.CourseId);

            modelBuilder.Entity<Course>()
                        .Property(c => c.Price)
                        .HasPrecision(18, 2);


            modelBuilder.Entity<Instructor>().HasData(
                        new Instructor { Id = 1, FullName = "ENES KILIÇ", Email="enes@gmail.com",Biography ="sdf", Courses = null},
                        new Instructor { Id = 1, FullName = "Ayşe Par", Email="aysepar@gmail.com",Biography = "fdsf",Courses = null },
                        new Instructor { Id = 1, FullName = "Pelin Tere", Email = "pelin@gmail.com",Courses = null }
                );
        }

    }
}
