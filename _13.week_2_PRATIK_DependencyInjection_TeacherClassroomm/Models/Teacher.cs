using _13.week_2_PRATIK_DependencyInjection_TeacherClassroomm.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.week_2_PRATIK_DependencyInjection_TeacherClassroomm.Models
{
    internal class Teacher: IOgretmen
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Teacher(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string GetInfo()
        {
            return $"Teacher Name: {FirstName} {LastName}";
        }
    }
}
