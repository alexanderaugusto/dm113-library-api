using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
[ApiController]
public class BookController : ControllerBase
{
    private readonly LibraryDbContext _context;

    public BookController(LibraryDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetBooks()
    {
        var books = _context.Books.ToList();
        return Ok(books);
    }

    [HttpPost]
    public IActionResult AddBook(Book book)
    {
        _context.Books.Add(book);
        _context.SaveChanges();

        return CreatedAtAction(nameof(GetBooks), new { id = book.Id }, book);
    }

    [HttpGet("{id}")]
    public IActionResult GetBookById(int id)
    {
        var book = _context.Books.FirstOrDefault(b => b.Id == id);

        if (book == null)
            return NotFound();

        return Ok(book);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateBook(int id, Book bookRequest)
    {
        var book = _context.Books.Find(id);
        if (book == null)
            return NotFound();

        book.Title = bookRequest.Title;
        book.Author = bookRequest.Author;

        _context.Books.Update(book);
        _context.SaveChanges();

        return Ok(book);
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteBook(int id)
    {
        var book = _context.Books.Find(id);
        if (book == null)
            return NotFound();

        _context.Books.Remove(book);
        _context.SaveChanges();

        return NoContent();
    }
}
