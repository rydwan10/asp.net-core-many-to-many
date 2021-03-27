using ManyToMany.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManyToMany.ViewModels
{
    public class BookAuthorViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<AuthorViewModel> Authors { get; set;}
    }
}
