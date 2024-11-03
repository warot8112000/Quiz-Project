using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System;

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
        //virtual giúp EF thực hiện lazy loading và hỗ trợ trong proxy creation
        //Lazy loading là cách Entity Framework(EF) trì hoãn việc tải dữ liệu từ cơ sở dữ liệu cho đến khi bạn thực sự cần dùng nó.

        public virtual Question Question { get; set; } 
        public virtual UserQuiz UserQuiz { get; set; }
    }
}
