using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    [Table("UserQuiz")]
    public class UserQuiz
    {
        [Key]
        public int UserQuizId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        [ForeignKey("Quiz")]
        public int QuizId { get; set; }

        public DateTime StartedAt { get; set; } = DateTime.Now;

        public DateTime? CompletedAt { get; set; }

        public virtual User User { get; set; }
        public virtual Quiz Quiz { get; set; }
        public virtual ICollection<Answer> Answers { get; set; } = new List<Answer>();
    }
}
