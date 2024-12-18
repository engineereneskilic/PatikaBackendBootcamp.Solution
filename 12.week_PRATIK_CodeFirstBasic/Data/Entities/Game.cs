namespace _12.week_PRATIK_CodeFirstBasic.Data.Entities
{
    public class Game
    {
        public int Id { get; set; }             // Birincil anahtar
        public string Name { get; set; }        // Oyunun adı
        public string Platform { get; set; }    // Platform bilgisi
        public decimal Rating { get; set; }     // Puan (0-10 arasında)
    }
}
