using System.ComponentModel;

namespace _12.week_PRATIK_SURVIVOR.Models
{
    /// <summary>
    /// Yarışmacı tablosu.
    /// </summary>
    
    public class Competitor : BaseEntity
    {
        public string FirstName { get; set; } = string.Empty; // Yarışmacının Adı
        public string LastName { get; set; } = string.Empty; // Yarışmacının soyadı
        
        public int CategoryId { get; set; } // Kategori ile ilişki
        public Category? Category { get; set; }

    }
}
