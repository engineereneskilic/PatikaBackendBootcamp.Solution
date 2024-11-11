using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.week_ExceptionManagement
{
    public class User
    {
       public void SetAge(int age)
        {
            if(age < 0)
            {
                throw new InvalidAgeException("yaş negatif girilemez");
            }

            throw new Exception();
        }
    }

    public class InvalidAgeException: Exception
    {
        public InvalidAgeException(string message) : base(message)
        {




        }
    }
}
