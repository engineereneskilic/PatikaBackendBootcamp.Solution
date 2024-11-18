using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.week_5_Linq_Advanced
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }


    public class Grade
    {
        public int StudentID { get; set; }
        public string Course { get; set; }
        public int Score { get; set; }
    }
}
