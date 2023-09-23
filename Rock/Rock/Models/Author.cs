using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Author
    {
        public int AuthorID { get; set; }

        [Required]
        [Display(Name = "Author Name")]
        public string? AuthorName { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Number of Books Published")]
        public int NumberOfBooksPublished { get; set; }

        [Display(Name = "Royalty Company")]
        public string? RoyaltyCompany { get; set; }
    }


