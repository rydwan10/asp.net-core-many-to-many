using ManyToMany.Context;
using ManyToMany.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManyToMany.Services
{
    public class BooksService
    {
        public readonly BookContext _context;

        public BooksService(BookContext context)
        {
            _context = context;
        }
        public async Task<List<Book>> GetAsync()
        {
            List<Book> result = await _context.Books.Include(x => x.BookAuthors).ThenInclude(x => x.Author).AsNoTracking().ToListAsync();

            foreach (var item in result)
            {
                item.BookAuthors.ForEach(x =>
                {
                    x.Author.BookAuthors = null;
                });
            }

            return result;
        }
    }
}
