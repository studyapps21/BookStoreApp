﻿using Microsoft.AspNetCore.Mvc;
using Prag.BookStore.Models;
using Prag.BookStore.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prag.BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;
        public BookController()
        {
            _bookRepository = new BookRepository();
        }
        public ActionResult getAllBooks()
        {
           var data= _bookRepository.GetAllBooks();

           return View(data);
        }

        public ActionResult getBook(int id)
        {
            var data = _bookRepository.GetBookById(id);
            return View(data);
        }

        public List<BookModel> searchBooks(string bookName , string authorName)
        {
            List<BookModel> abc = _bookRepository.SearchBook(bookName, authorName);
            return abc;
        }
    }
}
