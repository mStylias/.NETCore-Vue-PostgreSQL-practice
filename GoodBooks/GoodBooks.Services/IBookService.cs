using GoodBooks.Data.Models;

namespace GoodBooks.Services
{
    public interface IBookService
    {
        public List<Book> GetAllBooks();
        public Book GetBook(int bookID);
        public void AddBook(Book book);
        public void DeleteBook(int bookID);
    }
}