// Dependency Injection için ServiceProvider kur
using _13.week_2_PRATIK_DependencyInjection_TeacherClassroomm.Interfaces;
using _13.week_2_PRATIK_DependencyInjection_TeacherClassroomm.Models;
using Microsoft.Extensions.DependencyInjection;

var serviceProvider = new ServiceCollection()
    .AddTransient<IOgretmen>(provider => new Teacher("John", "Doe"))
    .AddTransient<ClassRoom>()
    .BuildServiceProvider();

// ClassRoom nesnesini çözümle
var classRoom = serviceProvider.GetService<ClassRoom>();

// Öğretmenin bilgilerini al ve yazdır
if (classRoom != null)
{
    Console.WriteLine(classRoom.GetTeacherInfo());
}

Console.ReadKey();