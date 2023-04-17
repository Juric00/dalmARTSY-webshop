using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dalmARTSY_Test.Models
{
    public class OrderItem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int OrderId { get; set; }
        [ForeignKey(nameof(OrderId))]
        public Order? Order { get; set; }

        [Required]
        public int ProductId { get; set; }
        [ForeignKey(nameof(ProductId))]
        public Product? Product { get; set; }

        [Required]
        [StringLength(250)]
        public string ProductTitle { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        [Column(TypeName= "decimal(9,2)")]
        public decimal Price { get; set; }

        [Required]
        [Column(TypeName = "decimal(9,2)")]
        public decimal TotalPrice { get; set; }
    }
}
