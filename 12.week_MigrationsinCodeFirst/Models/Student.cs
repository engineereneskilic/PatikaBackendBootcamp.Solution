using System.ComponentModel.DataAnnotations;

namespace _12.week_MigrationsinCodeFirst.Models
{
    public class Student :BaseModel<int>
    {
        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(100)]
        public string LastName { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        public DateTime DateOfBirth { get; set; }

        public List<Enrollment> Enrollments { get; set; }

    }
}
