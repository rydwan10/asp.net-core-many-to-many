using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ManyToMany.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(225)]
        [Required]
        public string Name { get; set; }

        public List<BookAuthor> BookAuthors { get; set; }

    }
}
