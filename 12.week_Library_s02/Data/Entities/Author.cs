namespace _12.week_Library_s02.Data.Entities
{
    public class Author
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime DateofBirth { get; set; }

        public List<Book> Books { get; set;}
    }
}
