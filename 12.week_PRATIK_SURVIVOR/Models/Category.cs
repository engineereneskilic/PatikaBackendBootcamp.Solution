namespace _12.week_PRATIK_SURVIVOR.Models
{
    public class Category : BaseEntity
    {
        public string Name { get; set; } = string.Empty; // Kategori adı;
        public ICollection<Competitor> Competitors { get; set; } = new List<Competitor>(); //Kategoriye ait yarışmacılar
    }
}
