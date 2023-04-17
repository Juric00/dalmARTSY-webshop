using System.ComponentModel.DataAnnotations;

namespace dalmARTSY_Test.Models
{
    public class Style
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string Title { get; set; }

        [Required]
        [StringLength(1500)]
        public string About { get; set; }
    }
}
