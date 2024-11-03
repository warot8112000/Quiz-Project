using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    [Table("Quiz")]
    public class Quiz
    {
        [Key]
        public int QuizId { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [ForeignKey("User")]
        public int CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [ForeignKey("Level")]
        public int LevelId { get; set; }

        public int? TimeTaken { get; set; }
        public int? Points { get; set; }

        public virtual User User { get; set; }
        public virtual Level Level { get; set; }
        public virtual ICollection<QuizCategory> QuizCategories { get; set; } = new List<QuizCategory>();
        public virtual ICollection<Question> Questions { get; set; } = new List<Question>();
        public virtual ICollection<UserQuiz> UserQuizzes { get; set; } = new List<UserQuiz>();
    }
}
