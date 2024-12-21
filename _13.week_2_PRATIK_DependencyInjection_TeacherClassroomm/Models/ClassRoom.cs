using _13.week_2_PRATIK_DependencyInjection_TeacherClassroomm.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.week_2_PRATIK_DependencyInjection_TeacherClassroomm.Models
{
    public class ClassRoom
    {
        private readonly IOgretmen _teacher;

        public ClassRoom(IOgretmen teacher)
        {
            _teacher = teacher;
        }

        public string GetTeacherInfo()
        {
            return _teacher.GetInfo();
        }
    }
}
