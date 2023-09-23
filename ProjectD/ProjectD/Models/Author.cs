using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjectD.Models
{
    public class Author
    {
        [Key] // square brackets are called as annotations . Annotations are meta data which means additional info 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AuthorID { set; get; }
       
        public String AuthorName { set; get; }
        [Range(50, 10000, ErrorMessage = "Cost must be between 50 and 10000")]

        public DateTime DateofBirth { set; get; }
        public int NoOfBooks { set; get; }
        [StringLength(25, ErrorMessage = "Name must not have more than 25 chars")]
        [MinLength(3, ErrorMessage = "Name must have at least 3 chars")]
        [Required(ErrorMessage = "Name is Required")]
        public String RoyaltyCompany { set; get; }
    }
}
    
