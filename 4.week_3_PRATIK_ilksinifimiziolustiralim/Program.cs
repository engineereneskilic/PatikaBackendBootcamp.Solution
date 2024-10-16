using System;

namespace _4.week_3_PRATIK_ilksinifimiziolustiralim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bir öğrenci nesnesi oluşturuluyor
            Person student = new Person();
            student.FirstName = "Ali";
            student.LastName = "Yılmaz";
            student.BirthDate = new DateTime(2005, 7, 23);

            // Öğrencinin bilgileri ekrana yazdırılıyor
            Console.WriteLine($"Öğrencinin Adı: {student.FirstName}");
            Console.WriteLine($"Öğrencinin Soyadı: {student.LastName}");
            Console.WriteLine($"Öğrencinin Doğum Tarihi: {student.BirthDate.ToShortDateString()}");

            // Öğretmen nesnesi oluşturuluyor
            Person teacher = new Person();
            teacher.FirstName = "Ayşe";
            teacher.LastName = "Kara";
            teacher.BirthDate = new DateTime(1980, 4, 18);

            // Öğretmenin bilgileri ekrana yazdırılıyor
            Console.WriteLine($"\nÖğretmenin Adı: {teacher.FirstName}");
            Console.WriteLine($"Öğretmenin Soyadı: {teacher.LastName}");
            Console.WriteLine($"Öğretmenin Doğum Tarihi: {teacher.BirthDate.ToShortDateString()}");
        }
    }
}
