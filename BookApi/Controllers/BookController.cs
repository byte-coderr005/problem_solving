using BookApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private static List<Book> books = new()
        {
        new Book { Id = 1, Title = "Dune",Author = "Frank Herbert" },
        new Book { Id = 2, Title = "1984", Author = "George ORwell" },
        new Book{ Id = 3, Title = "Clean Code", Author = "Robert Martin" }
        };
        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetAll()
         => Ok(books);
        [HttpGet("{id}")]
        public ActionResult<Book> GetById(int id)
        {
            var book = books.FirstOrDefault(x => x.Id == id);
            if(book is null) return NotFound();
            return Ok(book);
        }
        [HttpPost]
        public ActionResult<Book> Create(Book newBook)
        {
            newBook.Id = books.Max(b => b.Id) + 1;
            books.Add(newBook);
            return CreatedAtAction(nameof(GetById), new { id = newBook.Id }, newBook);
        }
        [HttpPut("{id}")]
        public IActionResult Update(int id, Book updated)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book is null) return NotFound();

            book.Title = updated.Title;
            book.Author = updated.Author;
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book is null) return NotFound();

            books.Remove(book);
            return NoContent();
        }

    }
}
