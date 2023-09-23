using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MvcefApp.Models
{
    public class Patient
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [MinLength(3, ErrorMessage = "Name must be between 3 and 20 character")]
        public string Name { get; set; } = string.Empty;
        [Required]

        public string City { get; set; } = string.Empty;
        [Required]
        public DateTime DateofBirth { get; set; }
        [Required]
        [Column(TypeName = "numeric(18,0)")]
        public decimal PhoneNumber { get; set; }
        [Required]

        public long Nothing { get; set; }
    }
}

