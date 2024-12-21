namespace _12.week_PRATIK_SURVIVOR.DTos
{
    public class CategoryDTO
    {
        public int Id { get; set; } // Kategori ID'si
        public string Name { get; set; } = string.Empty; // Kategori adı
        public List<string> Competitors { get; set; } = new(); // Yarışmacı adları listesi
    }
}
