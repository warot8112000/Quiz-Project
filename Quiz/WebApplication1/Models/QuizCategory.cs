using static WebApplication1.Models.Caterogy;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    [Table("QuizCategory")]
    public class QuizCategory
    {
        [Key]
        public int QuizCategoryId { get; set; }

        [ForeignKey("Quiz")]
        public int QuizId { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        public virtual Quiz Quiz { get; set; }
        public virtual Category Category { get; set; }
    }
}
