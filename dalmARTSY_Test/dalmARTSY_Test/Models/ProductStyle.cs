using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dalmARTSY_Test.Models
{
    public class ProductStyle
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int ProductId { get; set; }

        [ForeignKey(nameof(ProductId))]
        public Product? Product { get; set; }

        [Required]
        public int StyleId { get; set; }

        [ForeignKey(nameof(StyleId))]
        public Style? Style { get; set; }
    }
}
