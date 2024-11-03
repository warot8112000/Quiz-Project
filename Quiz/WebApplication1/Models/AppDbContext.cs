using Microsoft.EntityFrameworkCore;
namespace WebApplication1.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Level> Levels { get; set; }
        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<QuizCategory> QuizCategories { get; set; }
        public DbSet<QuestionType> QuestionTypes { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<AnswerOption> AnswerOptions { get; set; }
        public DbSet<UserQuiz> UserQuizzes { get; set; }
        public DbSet<Answer> Answers { get; set; }


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=MACOSF41C\\THANG;Initial Catalog=Quiz;Integrated Security=True;Trust Server Certificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Cấu hình các mối quan hệ giữa các bảng và các ràng buộc nếu cần thiết
            modelBuilder.Entity<QuizCategory>()
                .HasOne(qc => qc.Quiz)
                .WithMany(q => q.QuizCategories)
                .HasForeignKey(qc => qc.QuizId);

            modelBuilder.Entity<QuizCategory>()
                .HasOne(qc => qc.Category)
                .WithMany(c => c.QuizCategories)
                .HasForeignKey(qc => qc.CategoryId);

            modelBuilder.Entity<Question>()
                .HasOne(q => q.Quiz)
                .WithMany(quiz => quiz.Questions)
                .HasForeignKey(q => q.QuizId);

            modelBuilder.Entity<Question>()
                .HasOne(q => q.QuestionType)
                .WithMany(qt => qt.Questions)
                .HasForeignKey(q => q.QuestionTypeId);

            modelBuilder.Entity<AnswerOption>()
                .HasOne(ao => ao.Question)
                .WithMany(q => q.AnswerOptions)
                .HasForeignKey(ao => ao.QuestionId);

            modelBuilder.Entity<UserQuiz>()
                .HasOne(uq => uq.User)
                .WithMany(u => u.UserQuizzes)
                .HasForeignKey(uq => uq.UserId);

            modelBuilder.Entity<UserQuiz>()
                .HasOne(uq => uq.Quiz)
                .WithMany(q => q.UserQuizzes)
                .HasForeignKey(uq => uq.QuizId);

            modelBuilder.Entity<Answer>()
                .HasOne(a => a.Question)
                .WithMany(q => q.AnswerOptions)
                .HasForeignKey(a => a.QuestionId);

            modelBuilder.Entity<Answer>()
                .HasOne(a => a.UserQuiz)
                .WithMany(uq => uq.Answers)
                .HasForeignKey(a => a.UserQuizId);
        }
    }
}
