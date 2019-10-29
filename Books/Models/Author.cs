using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Books.Models
{
    public class Author
    {
        public int AuthorId { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string MyProperty { get; set; }//MyProperty é na realidade NOME mas enganei-me
    }
}
