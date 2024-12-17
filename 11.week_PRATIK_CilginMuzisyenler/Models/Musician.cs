namespace _11.week_PRATIK_CilginMuzisyenler.Models
{
    // Musician model representing a musician entity.
    public class Musician
    {
        public int Id { get; set; }            // Unique ID for each musician.
        public string Name { get; set; }       // Name of the musician.
        public string Profession { get; set; } // Musician's profession.
        public string FunTrait { get; set; }   // A funny or unique trait about the musician.
    }
}
