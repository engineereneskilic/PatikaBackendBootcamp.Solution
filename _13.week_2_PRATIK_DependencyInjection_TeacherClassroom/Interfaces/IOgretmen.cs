namespace _13.week_2_PRATIK_DependencyInjection_TeacherClassroom.Interfaces
{
    public interface IOgretmen
    {
        string FirstName { get; set; }
        string LastName { get; set; }

        string GetInfo();

    }
}
