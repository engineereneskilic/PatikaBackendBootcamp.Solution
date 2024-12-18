namespace _12.week_PRATIK_CodeFirstRelation.Data.Entities
{
    public class Post
    {
        public int Id { get; set; } // Primary key for the Post table.
        public string Title { get; set; } // The title of the post.
        public string Content { get; set; } // The content of the post.

        public int UserId { get; set; } // Foreign key referencing the User table.

        // Navigation property to the User entity.
        public User User { get; set; }
    }
}
