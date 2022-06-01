using System.Diagnostics;
using GoodBooks.Data.Models;
using GoodBooks.Services;
using GoodBooks.Web.RequestModels;
using Microsoft.AspNetCore.Mvc;

namespace GoodBooks.Web.Controllers;

[ApiController]
public class BooksController : ControllerBase
{
    private readonly ILogger<BooksController> _logger;
    private readonly IBookService _bookService;

    public BooksController(ILogger<BooksController> logger, IBookService bookService)
    {
        _logger = logger;
        _bookService = bookService;
    }

    [HttpGet("/api/books")]
    public ActionResult GetBooks()
    {
        var books = _bookService.GetAllBooks();
        return Ok(books);
    }

    [HttpPost("/api/books")]
    public ActionResult CreateBook([FromBody]NewBookRequest bookRequest)
    {
        if (!ModelState.IsValid)
            return BadRequest();
    
        var now = DateTime.UtcNow;
        
        var book = new Book()
        {
            CreatedOn = now,
            UpdatedOn = now,
            Title = bookRequest.Title,
            Author = bookRequest.Author
        };
        
        _bookService.AddBook(book);
        return Ok($"Book created: {book.Title}");
    }

    [HttpGet("/api/books/{id}")]
    public ActionResult GetBook(int id)
    {
        return Ok(_bookService.GetBook(id));
    }
    
    [HttpDelete("/api/books/{id}")]
    public ActionResult DeleteBook(int id)
    {
        _bookService.DeleteBook(id);
        return Ok($"Book with id {id} deleted successfully");
    }
}
