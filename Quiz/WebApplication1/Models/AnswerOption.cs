using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    [Table("AnswerOption")]
    public class AnswerOption
    {
        [Key]
        public int OptionId { get; set; }

        [ForeignKey("Question")]
        public int QuestionId { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public bool IsCorrect { get; set; }

        public int? RankingPosition { get; set; }

        public virtual Question Question { get; set; }
    }
}
