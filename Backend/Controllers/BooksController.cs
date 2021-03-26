using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TestApi.Models;

namespace TestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {
        private static readonly Book[] Books = new[]
        {
            new Book {
                Id = 1,
                Name = "The Hobbit",
                Author = "J. R. R. Tolkien"
            },
            new Book {
                Id = 2,
                Name = "The Bromeliad",
                Author = "Terry Pratchett"
            },
            new Book {
                Id = 3,
                Name = "Taran",
                Author = "Lloyd Alexander"
            }
        };

        [HttpGet]
        public ActionResult<Book[]> Get()
        {
            return Books;
        }

        [HttpGet("{id}")]
        public ActionResult<Book> Get(int id)
        {
            return Books.FirstOrDefault(i => i.Id == id);
        }
    }
}
