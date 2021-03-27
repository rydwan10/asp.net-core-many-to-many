using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ManyToMany.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(225)]
        public string Title { get; set; }

        [Required]
        [MaxLength(225)]
        public string Genre { get; set; }

        public List<BookAuthor> BookAuthors { get; set; }
       
    }
}
