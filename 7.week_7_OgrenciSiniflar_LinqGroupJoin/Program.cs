using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.week_7_OgrenciSiniflar_LinqGroupJoin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student { StudentId = 1, StudentName = "Ali", ClassId = 1 },
                new Student { StudentId = 2, StudentName = "Ayşe", ClassId = 2 },
                new Student { StudentId = 3, StudentName = "Mehmet", ClassId = 1 },
                new Student { StudentId = 4, StudentName = "Fatma", ClassId = 3 },
                new Student { StudentId = 5, StudentName = "Ahmet", ClassId = 2 }
            };

            List<Class> classes = new List<Class>
            {
                new Class { ClassId = 1, ClassName = "Matematik" },
                new Class { ClassId = 2, ClassName = "Türkçe" },
                new Class { ClassId = 3, ClassName = "Kimya" }
            };


            var groupJoinQuery = from cls in classes
                                 join std in students on cls.ClassId equals std.ClassId into studentGroup
                                 select new
                                 {
                                     ClassName = cls.ClassName,  // The name of the class
                                     Students = studentGroup    // Grouped list of students in the class
                                 };

            Console.WriteLine("Classes and their Students:");
            foreach (var group in groupJoinQuery)
            {
                Console.WriteLine($"Class: {group.ClassName}");
                foreach (var student in group.Students)
                {
                    Console.WriteLine($"  - {student.StudentName}");
                }
            }

        }
    }
}
