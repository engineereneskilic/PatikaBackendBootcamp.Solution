namespace _12.week_PRATIK_CodeFirstManyRelation.Models.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }

        //Dersin aldındığı Öğrenci listesi
        public List<StudentCourse> StudentCourses { get; set; }
    }
}
