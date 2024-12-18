namespace _12.week_PRATIK_CodeFirstManyRelation.Models.Entities
{
    public class StudentCourse
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }

        public int CoruseId { get; set; }
        public Course Course { get; set; }
    }
}