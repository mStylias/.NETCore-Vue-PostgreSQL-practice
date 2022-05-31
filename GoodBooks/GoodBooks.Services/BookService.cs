using GoodBooks.Data;
using GoodBooks.Data.Models;

namespace GoodBooks.Services;

public class BookService : IBookService
{
    private readonly GoodBooksDbContext _db;
    
    public BookService(GoodBooksDbContext db)
    {
        _db = db;
    }
    
    public List<Book> GetAllBooks()
    {
        return _db.Books.ToList();
    }

    public Book GetBook(int bookId)
    {
        return _db.Books.First(book => book.Id == bookId);
    }

    public void AddBook(Book book)
    {
        _db.Add(book);
        _db.SaveChanges();
    }

    public void DeleteBook(int bookId)
    {
        var bookToDelete = _db.Books.Find(bookId);
        if (bookToDelete != null)
        {
            _db.Remove(bookToDelete);
        }

        throw new InvalidOperationException(
            "Can't Delete book that doesn't exist"
        );
    }
}