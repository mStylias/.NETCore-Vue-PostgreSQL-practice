using GoodBooks.Data;
using GoodBooks.Data.Models;

namespace GoodBooks.Services;
public class BookService : IBookService
{
    private readonly GoodBooksDbContext _db;
    public BookService(GoodBooksDbContext dbContext)
    {
        _db = dbContext;
    }

    public void AddBook(Book book)
    {
        _db.Add(book);
        _db.SaveChanges();
    }

    public void DeleteBook(int bookID)
    {
        var bookToDelete = _db.Books.Find(bookID);
        if (bookToDelete != null)
        {
            _db.Remove(bookToDelete);
            _db.SaveChanges();
        }

        throw new InvalidOperationException("Cant delete a book that doesn't exist");
    }

    public List<Book> GetAllBooks()
    {
        return _db.Books.ToList();
    }

    public Book GetBook(int bookID)
    {
        return _db.Books.Find(bookID);
    }
}
