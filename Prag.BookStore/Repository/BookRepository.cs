using Prag.BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prag.BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x=>x.Id == id).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string title, string authorName)
        {
            return DataSource().Where(x => x.Title == title || x.Author == authorName).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){ Id = 1, Title ="MVC" , Author="Pragnesh" , Description="MVC is model view controller", Category="Programming" , Language="English", TotalPages=1234},
                new BookModel(){ Id = 2, Title ="c#" , Author="Yashumati", Description="C# is object oriented programming language", Category="Programming" , Language="English, French", TotalPages=4321},
                new BookModel(){ Id = 3, Title ="Angular" , Author="Krupali", Description="angular is framework for building SPA", Category="Framework" , Language="English, Hindi", TotalPages=4567},
                new BookModel(){ Id = 4, Title ="React" , Author="NT", Description="React is light weight client side library for building SPA", Category="Framework" , Language="English, spanish", TotalPages=7654}
            };
        }
    }
}
