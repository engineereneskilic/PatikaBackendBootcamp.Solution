using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.week_5_Linq_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
          List<Student> students = new List<Student>();

            students.Add(new Student { Id = 1, Name="Ali" });    
            students.Add(new Student { Id = 2, Name="Ayşe" });    
            students.Add(new Student { Id = 3, Name="Fatma" });    
            students.Add(new Student { Id = 4, Name="Enes" });

            List<Grade> grades = new List<Grade>();

            grades.Add(new Grade { StudentID = 1 , Course = "Matematik", Score = 89 });
            grades.Add(new Grade { StudentID = 2 , Course = "Kimya" , Score = 70 });
            grades.Add(new Grade { StudentID = 3 , Course = "Fizik" , Score = 76 });
            grades.Add(new Grade { StudentID = 4 , Course = "Elektrik" , Score = 10 });

            grades.Add(new Grade { StudentID = 1, Course = "Bilişim", Score = 49 });
            grades.Add(new Grade { StudentID = 2, Course = "Türkçe", Score = 36 });
            grades.Add(new Grade { StudentID = 3, Course = "İngilizce", Score = 75 });


            var studentGrades = students.Join(grades,
                                            student => student.Id,
                                            grade => grade.StudentID,
                                            (student, grade) => new
                                            {
                                                StudentName = student.Name,
                                                CourseName = grade.Course,
                                                Score = grade.Score
                                            }

                                            );

            var studentGrades2 = from student in students
                                join grade in grades
                                on student.Id equals grade.StudentID
                                select new
                                {
                                    StudentName = student.Name,
                                    CourseName = grade.Course,
                                    Score = grade.Score
                                };
                                

            foreach (var student in studentGrades2)
            {
              //  Console.WriteLine($"Öğrenci adı: {student.StudentName} ders {student.CourseName} Not {student.Score}");

            }


            var studentsWithGrades = students.GroupJoin(grades,
                                                        student => student.Id,
                                                        grade => grade.StudentID,
                                                        (student,studentGrades) => new
                                                        {
                                                            StudentName = student.Name,
                                                            Grades = studentGrades
                                                        }
                );

            foreach (var student in studentsWithGrades)
            {
                Console.WriteLine();
                Console.WriteLine($"{student.StudentName}");
                Console.WriteLine("---------- Dersleri");
                foreach (var grade in student.Grades)
                {
                    Console.WriteLine($"{grade.Course}  -- {grade.Score}");
                }
            }



            var numbers = new List<int>() { 1, 2, 3, 4, 5, 6 , 7 };

            var groupedAndASummed = numbers.GroupBy(num => num % 2 == 0 ? "Çift" : "Tek")
                                           .Select(group => new
                                           {
                                               Key = group.Key,
                                               Sum = group.Sum()

                                           });

            foreach (var group in groupedAndASummed)
            {
                Console.WriteLine($"{group.Key} Sayılar -  Toplam : {group.Sum}");
            }   

            //////////////////////////////////////////////////////

            var studentAverageGrades = students.Select(student => new
            {
                StudentName = student.Name,
                AverageGrade = grades.Where(s => s.StudentID == student.Id) // grade tablosundan ilgili studenta ait tüm notlar alındı
                               .Average(g => g.Score)   // bu tüm notların ortalması alındı
            });
            Console.WriteLine();
            Console.WriteLine();
            foreach (var student in studentAverageGrades)
            {
                Console.WriteLine($"{student.StudentName} ortalama: {student.AverageGrade}");

            }
            Console.WriteLine();
            Console.WriteLine();

            var pagedStudents = students.OrderBy(student => student.Name)
                                        .Skip(0)
                                        .Take(1);

            students.Any( student => student.Name.StartsWith("A") ); // a ile başlayan hiç öğrenci varmı
            students.All( student => student.Name.StartsWith("A")  );

            students.Count( student => student.Id > 0 );


            Console.ReadKey();

        }
    }
}
