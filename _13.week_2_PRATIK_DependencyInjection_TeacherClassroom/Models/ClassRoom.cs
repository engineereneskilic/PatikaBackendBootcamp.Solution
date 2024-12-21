using _13.week_2_PRATIK_DependencyInjection_TeacherClassroom.Interfaces;

namespace _13.week_2_PRATIK_DependencyInjection_TeacherClassroom.Models
{
    public class ClassRoom
    {
        private readonly IOgretmen _teacher;

        public ClassRoom(IOgretmen teacher)
        {
            _teacher = new Teacher();
        }

        public string GetTeacherInfo()
        {
            return _teacher.GetInfo();
        }
    }
}
