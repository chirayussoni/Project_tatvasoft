<<<<<<< HEAD
﻿using Books.DataAccess.Models;
using Books.Services.Services;
=======
﻿using Book_Management.Models;
using Book_Management.Services;
>>>>>>> aa1319a (comited)
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Book_Management.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
<<<<<<< HEAD
        private readonly BooksService _bookService;

        public BooksController(BooksService bookService)
=======
        private readonly BookService _bookService;

        public BooksController(BookService bookService)
>>>>>>> aa1319a (comited)
        {
            _bookService = bookService;
        }

        [HttpGet("GetAllBooks")]
        public ActionResult<List<Book>> GetAllBooks()
        {
            List<Book> books = _bookService.GetBooks();
<<<<<<< HEAD
            if (books == null || books.Count == 0)
=======
            if(books == null || books.Count == 0)
>>>>>>> aa1319a (comited)
            {
                return NotFound("No books found");
            }
            else
            {
                return Ok(books);
            }
        }

        [HttpGet("GetSingleBook")]
        public ActionResult<Book> GetBook(int id)
        {
            Book book = _bookService.GetBookById(id);
            if (book == null)
            {
                return NotFound("Book Not found");
            }
            else
            {
                return Ok(book);
            }
        }

        [HttpPost]
        public ActionResult AddBook(Book book)
        {
            _bookService.AddBook(book);
            return Ok("Book added successfully");
        }

        [HttpPut]
        public ActionResult UpdateBook(Book bookToBeUpdated)
        {
            int bookUpdateStatus = _bookService.UpdateBook(bookToBeUpdated);
<<<<<<< HEAD
            if (bookUpdateStatus == -1)
            {
                return NotFound("Book Not FOund");
            }
            else if (bookUpdateStatus == 1)
=======
            if(bookUpdateStatus == -1)
            {
                return NotFound("Book Not FOund");
            }
            else if(bookUpdateStatus == 1)
>>>>>>> aa1319a (comited)
            {
                return Ok("Book updated successfully");
            }
            else
            {
                return BadRequest("Bad request");
            }
        }

        [HttpDelete]
        public ActionResult DeleteBook(int id)
        {
            int deleteStatus = _bookService.DeleteBook(id);
<<<<<<< HEAD
            if (deleteStatus == -1)
=======
            if(deleteStatus == -1)
>>>>>>> aa1319a (comited)
            {
                return NotFound("Book Not found");
            }
            else if (deleteStatus == 1)
            {
                return Ok("Book Deleted Successfully");
            }
            else
            {
                return BadRequest("Bad request");
            }
        }
<<<<<<< HEAD

        [HttpGet("GetFilteredBooks")]
        public ActionResult GetFilteredBooks(string genre)
        {
            List<Book> books = _bookService.GetFilteredBooks(genre);
            if(books == null || books.Count == 0)
            {
                return NotFound("Books Not Found");
            }
            else
            {
                return Ok(books);
            }

        }
=======
>>>>>>> aa1319a (comited)
    }
}
