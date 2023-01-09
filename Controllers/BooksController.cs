using BookStore.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : Microsoft.AspNetCore.Mvc.ControllerBase
    {
        private readonly BookService _bookService;

        public BooksController()
        {
            _bookService = new BookService();
        }

        [HttpGet]
        public IActionResult GetAllBooks()
        {
            var books = _bookService.GetAllBooks();
            return Ok(books);
        }

        [HttpGet("{id}")]
        public IActionResult GetBookById(int id)
        {
            var book = _bookService.GetBookById(id);
            if (book == null)
            {
                return NotFound();
            }
            return Ok(book);
        }

        [HttpGet("authors")]
        public IActionResult GetAuthors()
        {
            var authors = _bookService.GetAuthors();
            return Ok(authors);
        }

        [HttpGet("authors/{id}")]
        public IActionResult GetAuthorById(int id)
        {
            var author = _bookService.GetAuthorById(id);
            if (author == null)
            {
                return NotFound();
            }
            return Ok(author);
        }

        [HttpGet("authors/{authorId}/books")]
        public IActionResult GetBooksByAuthorId(int authorId)
        {
            var books = _bookService.GetBooksByAuthorId(authorId);
            return Ok(books);
        }
    }
}
