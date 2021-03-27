using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ManyToMany.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(225)]
        [Required]
        public string CourseName { get; set; }

        [MaxLength(225)]
        [Required]
        public string Description { get; set; }

    }
}
