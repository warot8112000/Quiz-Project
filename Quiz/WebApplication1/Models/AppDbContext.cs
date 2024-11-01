using Microsoft.EntityFrameworkCore;
namespace WebApplication1.Models
{
        public class AppDbContext : DbContext
        {
            

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("Data Source=MACOSF41C\\THANG;Initial Catalog=Quiz;Integrated Security=True;Trust Server Certificate=True");
            }
        }
}
