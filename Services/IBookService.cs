using BookStore.DTO;

namespace BookStore.Services
{
    public interface IBookService
    {
        IEnumerable<Book> GetAllBooks();
        Book GetBookById(int id);
        IEnumerable<Author> GetAuthors();
        Author GetAuthorById(int id);
        IEnumerable<Book> GetBooksByAuthorId(int authorId);
    }
}
