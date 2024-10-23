using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.week_12_inheritance_animal
{

    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void Work()
        {
            Console.WriteLine("Working");
        }
    }

    public class Teacher: Person
    {
        public void Teach()
        {
            Console.WriteLine("teaching");
        }
    }

    public class Student: Person
    {
        public void Study()
        {
            Console.WriteLine("Studying");
        }
    }


}
