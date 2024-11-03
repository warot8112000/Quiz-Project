using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    [Table("Category")]
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        [StringLength(100)]
        public string CategoryName { get; set; }

        // Các mối quan hệ
        public virtual ICollection<QuizCategory> QuizCategories { get; set; } = new List<QuizCategory>();
    }
}
