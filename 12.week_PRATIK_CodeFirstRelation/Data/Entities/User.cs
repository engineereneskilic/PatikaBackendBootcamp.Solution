using Microsoft.Extensions.Hosting;

namespace _12.week_PRATIK_CodeFirstRelation.Data.Entities
{
    public class User
    {
        public int Id { get; set; } // Primary key for the User table.
        public string Username { get; set; } // The username of the user.
        public string Email { get; set; } // The email of the user.

        // Navigation property representing the one-to-many relationship with Posts.
        public ICollection<Post> Posts { get; set; }
    }
}
