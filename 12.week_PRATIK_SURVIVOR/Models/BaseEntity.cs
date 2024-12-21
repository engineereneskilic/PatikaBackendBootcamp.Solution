namespace _12.week_PRATIK_SURVIVOR.Models
{
    /// <summary>
    /// BaseEntity sınıfı tüm tablolarda ortak olacak özellikleri içerir.
    /// </summary>
    public abstract class BaseEntity
    {
        public int Id {  get; set; } // Birincil Anahtar
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow; // oluşturulma Tarihi
        public DateTime? ModifiedDate { get; set; } // Güncelleme Tarihi
        public bool IsDeleted { get; set; } = false; // Silinme Durumu
    }
}
