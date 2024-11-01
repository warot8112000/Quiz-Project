using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{

    [Table("Level")]
    public class Level
    {
        [Key]
        public int LevelId { get; set; }

        [Required]
        [StringLength(100)]
        public string LevelName { get; set; }
    }

}
