using _12.week_Library_s02.Data;
using _12.week_Library_s02.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;

namespace _12.week_Library_s02.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly LibraryDbContext db;

        public BooksController(LibraryDbContext libraryDbContext)
        {
            db = libraryDbContext;
        }

        [HttpPost]
        public ActionResult<Book> Post([FromBody] Book book)
        {
            db.Books.Add(book);
            db.SaveChanges();

            return Ok(book);
        }

        [HttpPut("id")]
        public IActionResult Put(int id,[FromBody] Book book)
        {
            var current = db.Books.FirstOrDefault(b => b.Id == id);
            
            if(current == null)
            {
                return NotFound();
            }

            current.Title = book.Title;
            current.LastBorrowedDate = book.LastBorrowedDate;
            current.Price = book.Price;
            current.CategoryId = book.CategoryId;

            db.SaveChanges();

            return NoContent();
        }

        [HttpGet()]
        public ActionResult<List<Book>> GetAll()
        {
            var recentBooks = db.Books
                              .Where(b => b.PublicationYear > 2020)
                              .OrderByDescending(b => b.PublicationYear)
                              .Take(10)
                              .ToList();
            //var books = db.Books.FromSqlRaw("Select * from Books Where PublicationYear > {0}", 2020).ToList();

            return Ok(recentBooks);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var current = db.Books.FirstOrDefault(b => b.Id == id);

            if (current == null) NotFound();

            db.Books.Remove(current);

            db.SaveChanges();

            return NoContent();
        }

    }
}
