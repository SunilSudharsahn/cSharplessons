using System.ComponentModel.DataAnnotations;

namespace ProjectD.Models
{
    public class Employee
    {
        internal string name;
        internal object eno;

        public decimal salary { get; internal set; }
        public string city { get; internal set; }
        public object Id { get; internal set; }
        public object Name { get; internal set; }

        public enum EmployeeEnum
        {
            Chennai
            
        }
        public class CreateEMP
        {
            [Key]
            public int eno { get; set; }
            [Required]
            [StringLength(20)]
            [MinLength(3,ErrorMessage ="Name must be 3 and 20")]
            public string name { get; set; }
            public decimal salary { get; set; }

            public string City { get; set; }

        }
    }
}
