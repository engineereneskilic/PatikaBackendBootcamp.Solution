using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;

namespace _12.week_MigrationsinCodeFirst.Models
{
    public class Instructor : BaseModel<int>
    {
        //[StringLength(50)]
        //public string FirstName { get; set; }

        //[StringLength(100)]
        //public string LastName { get; set; }

        public string FullName { get; set; }


        [StringLength(100)]
        public string Email { get; set; }

        public List<Course> Courses { get; set; }

     
        public string Biography { get; set; }
    }
}
