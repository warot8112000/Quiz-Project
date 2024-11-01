using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [StringLength(100)]
        public string Username { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(255)]
        public string Password { get; set; }

        // Các mối quan hệ
        public virtual ICollection<UserQuiz> UserQuizzes { get; set; } = new List<UserQuiz>();
        public virtual ICollection<Quiz> CreatedQuizzes { get; set; } = new List<Quiz>();
    }


}
