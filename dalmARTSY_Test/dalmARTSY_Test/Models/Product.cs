using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dalmARTSY_Test.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category? Category { get; set; }

        [Required]
        [StringLength(250)]

        public string Author { get; set; }

        [Required]
        [StringLength(250)]
        public string Title { get; set; }

        [Required]
        public decimal Height { get; set; }

        [Required]
        public decimal Width { get; set; }

        [Column(TypeName = "nvarchar(400)")]
        public string? Description { get; set; }
        public bool? Frame { get; set; }

        [Required]
        public int InStock { get; set; } = 0;

        [Required]
        [Column(TypeName = "decimal(8,2)")]
        public decimal Price { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(15)")]
        public string ArtCode { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(200)")]
        public string Image { get; set; }




    }
}
