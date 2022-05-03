using GoodBooks.Data;
using GoodBooks.Data.Models;

namespace GoodBooks.Services;
public class BookService : IBookService
{
    private readonly GoodBooksDbContext _dbContext;
    public BookService(GoodBooksDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void AddBook(Book book)
    {
        throw new NotImplementedException();
    }

    public void DeleteBook(int bookID)
    {
        throw new NotImplementedException();
    }

    public List<Book> GetAllBooks()
    {
        throw new NotImplementedException();
    }

    public Book GetBook(int bookID)
    {
        throw new NotImplementedException();
    }
}
