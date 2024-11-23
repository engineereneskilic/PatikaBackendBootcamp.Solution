
using System.ComponentModel.DataAnnotations;

namespace _8.week_3_PRATIK_BlogProject.Models
{
    public class BlogPost
    {
        public int PostID { get; set; }

        [Required(ErrorMessage = "Başlık gereklidir")]
        [StringLength(100,ErrorMessage = "100 karakterden fazla olamaz")]
        public string Title { get; set; }

        [Required(ErrorMessage = "İçerik gereklidir")]

        public string Content { get; set; }

        
        public DateTime CreatedDateTime { get; set; }

    }
}
