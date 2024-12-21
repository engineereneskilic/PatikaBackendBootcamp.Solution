using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.week_2_PRATIK_DependencyInjection_TeacherClassroomm.Interfaces
{
    public interface IOgretmen
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string GetInfo();
    }
}
