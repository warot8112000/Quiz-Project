using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    [Table("QuestionType")]
    public class QuestionType
    {
        [Key]
        public int QuestionTypeId { get; set; }

        [Required]
        [StringLength(100)]
        public string TypeName { get; set; }
        public virtual ICollection<Question> Questions { get; set; } = new List<Question>();
    }
}

