using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    [Table("Answer")]
    public class Answer
    {
        [Key]
        public int AnswerId { get; set; }

        [ForeignKey("Question")]
        public int QuestionId { get; set; }

        [ForeignKey("UserQuiz")]
        public int UserQuizId { get; set; }

        [Required]
        public string SelectedOptions { get; set; }

        public string? Content { get; set; }

        public string? RankedOptions { get; set; }

        public bool? IsCorrect { get; set; }

        public virtual Question Question { get; set; }
        public virtual UserQuiz UserQuiz { get; set; }
    }
}
