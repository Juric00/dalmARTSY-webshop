using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dalmARTSY_Test.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string Image { get; set; }
    }
}
