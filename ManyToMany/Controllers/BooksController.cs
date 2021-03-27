using ManyToMany.Context;
using ManyToMany.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManyToMany.Controllers
{
    [Route("api/books")]
    [ApiController]
    public class BooksController : Controller
    {

        private readonly BookContext _context;
        private readonly BooksService _bookService;

        public BooksController(BookContext context)
        {
            _context = context;
            _bookService = new BooksService(context);
        }
        
        [Route("")]
        [HttpGet]
        public async Task<ActionResult> GetAsync()
        {
            try
            {
                var result = await _bookService.GetAsync();
                if (result == null) return NotFound();

                return Ok(result);
            }
            catch (Exception e)
            {
                var msg = $"Error when getting Books with Authors {e.Message}";
                if(e.InnerException.Message != null)
                {
                    msg = $"Error when getting Books with Authors {e.InnerException.Message}";
                    return StatusCode(500, msg);

                }

                return StatusCode(500, msg);
            }
        }
    }
}
