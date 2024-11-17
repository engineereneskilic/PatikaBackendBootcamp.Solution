using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.week_Linq_where
{
    public class Person : IComparable<Person>
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public int CompareTo(Person other)
        {
            int result = 0;

            if(ID > other.ID)
            {
                result = 1;
            } else
            if(ID < other.ID )
            {
                result = -1;
            }

            return result;
        }

        public override string ToString()
        {
            return ID.ToString();
        }




    }
}
