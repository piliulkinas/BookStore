using BookStore.DTO;

namespace BookStore.Services
{
    public class BookService //: IBookService
    {
        private readonly List<Book> _books;
        private readonly List<Author> _authors;

        public BookService()
        {
            Author author1 = new Author { Id = 1, FirstName = "Author1", LastName = "One" };
            Author author2 = new Author { Id = 2, FirstName = "Author2", LastName = "Two" };
            Author author3 = new Author { Id = 3, FirstName = "Author3", LastName = "Three" };

            _authors = new List<Author>
            {
                author1,
                author2,
                author3
            };
            
            _books = new List<Book>
            {
                new Book { Id = 1, Title = "Book 1", Author = author1 },
                new Book { Id = 2, Title = "Book 2", Author = author2 },
                new Book { Id = 3, Title = "Book 3", Author = author3 },
                new Book { Id = 4, Title = "Book 4", Author = author1 },
                new Book { Id = 5, Title = "Book 5", Author = author2 },
                new Book { Id = 6, Title = "Book 6", Author = author3 },
                new Book { Id = 7, Title = "Book 7", Author = author1 },
                new Book { Id = 8, Title = "Book 8", Author = author2 },
                new Book { Id = 9, Title = "Book 9", Author = author3 }
            };
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _books;
        }

        public Book GetBookById(int id)
        {
            var book = _books.FirstOrDefault(b => b.Id == id);
            return book;
        }

        public IEnumerable<Author> GetAuthors()
        {
            return _authors;
        }

        public Author GetAuthorById(int id)
        {
            var author = _authors.FirstOrDefault(a => a.Id == id);
            return author;
        }

        public IEnumerable<Book> GetBooksByAuthorId(int authorId)
        {
            var books = _books.Where(b => b.Author.Id == authorId);
            return books;
        }
    }
}
