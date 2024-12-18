using _12.week_PRATIK_CodeFirstManyRelation.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace _12.week_PRATIK_CodeFirstManyRelation.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course>  Courses { get; set; }
        public DbSet<StudentCourse> StudentCourses  { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("ConnectionString");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // ArA tabloyu tanımlıyoruz
            modelBuilder.Entity<StudentCourse>()
                .HasKey(sc => new { sc.StudentId, sc.CoruseId }); // birincil anahyar olarak iki sütun
            /*
             *  Haskey metodu, StudentCourse tablosunda iki sütunun birincil anahtar olduğunu belirtir
             *  Not: HasKey aslında her zaman primary key tanımlarken var
             *  Eğer bir kolonu içerisinde 'id' geçerek tanımlıyorsanız Enitiy Framework onun primary key olduğunu
             *  anlayıp otomatik olarak haskey yazıyor.
             *  fakat siz başka bir kolonu örneğin 'TcKimlikNo' primary key yapmak istediniz, içerisinde 'id' olmadığından
             *  spesifik Haskey yazmak zorundasınız.
             * 
             *  çoka çok bağlantıda ise oaly şu, primary key 2 diğer tablodan gelen foreignkeyler olduğundan.
             * 
             * 
             * 
             * 
             * 
             * 
             * */
        }
    }
}
