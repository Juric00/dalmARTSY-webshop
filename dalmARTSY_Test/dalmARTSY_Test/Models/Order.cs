using dalmARTSY_Test.Areas.Identity.Data;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dalmARTSY_Test.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "datetime")]
        public DateTime OrderDate { get; set; } = DateTime.Now;

        [Required]
        [Column(TypeName = "decimal(9,2)")]
        public decimal Subtotal { get; set; }

        [Required]
        [Column(TypeName = "decimal(9,2)")]
        public decimal Tax { get; set; }

        [Required]
        [Column(TypeName = "decimal(9,2)")] 
        public decimal Total { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(450)")]
        public string? UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public AppUser? User { get; set; }
    }
}
