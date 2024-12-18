namespace _12.week_PRATIK_CodeFirstManyRelation.Models.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Öğrencinin aldığı reslerin listesi
        public List<StudentCourse> StudentCourses  { get; set; }
    }
}
