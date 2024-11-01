using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    [Table("Question")]
    public class Question
    {
        [Key]
        public int QuestionId { get; set; }

        [ForeignKey("Quiz")]
        public int QuizId { get; set; }

        [Required]
        public string Content { get; set; }

        public int Points { get; set; } = 1;

        [ForeignKey("QuestionType")]
        public int QuestionTypeId { get; set; }

        public virtual Quiz Quiz { get; set; }
        public virtual QuestionType QuestionType { get; set; }
    }
}
