using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SafariBooks_Employee.Models
{
    public class Book
    {
         [Key]
        public int SKU { get; set; }
        public string Title { get; set; }
        public string AuthorFirst { get; set; }
        public string AuthorLast { get; set; }
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
        public string Reviews { get; set; }

        public virtual List<Book> Books { get; set; }
    }
   

    }
