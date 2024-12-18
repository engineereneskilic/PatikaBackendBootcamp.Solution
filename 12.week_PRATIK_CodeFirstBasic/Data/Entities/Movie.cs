namespace _12.week_PRATIK_CodeFirstBasic.Data.Entities
{
    public class Movie
    {
        public int Id { get; set; }              // Birincil anahtar
        public string Title { get; set; }       // Filmin başlığı
        public string Genre { get; set; }       // Filmin türü
        public int ReleaseYear { get; set; }    // Çıkış yılı
    }
}
