using _13.week_2_PRATIK_DependencyInjection_TeacherClassroom.Interfaces;

namespace _13.week_2_PRATIK_DependencyInjection_TeacherClassroom.Models
{
    public class Teacher : IOgretmen
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string GetInfo()
        {
            return $"Teacher Name: {FirstName} {LastName}";
        }
    }
}
