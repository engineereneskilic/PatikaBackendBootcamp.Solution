using Microsoft.EntityFrameworkCore;

namespace _12.week_CodeFirst_01.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<StudentEntity> Students { get; set; } // StudentEntity yapılarının tutulacağı veri tablosunun adını Student Olarak Belirledik

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //@ -> Ters slash sorun yaratmasın diye.

            // Windows Authentication için
            optionsBuilder.UseSqlServer(@"server=DESKTOP-HDU6E5A;database=PatikaFirstDB;Trusted_Connection=true;TrustedServerCertificate=true");

            //Sql Server Authentication için
            //optionsBuilder.UseSqlServer(@"server=DESKTOP-HDU6E5A;database=PatikaFirstDB;uid=sa;pwd=sa; TrustServerCertificate=true");

            base.OnConfiguring(optionsBuilder);
            
        }

    }
}
