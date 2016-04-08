using System;
using System.Collections.Generic;
using System.Linq;
using CRUD_AngularJS_ASPNET_MVC_MAHESH.Core.Domain;
using CRUD_AngularJS_ASPNET_MVC_MAHESH.Core.Repositories.Interfaces;

namespace CRUD_AngularJS_ASPNET_MVC_MAHESH.DB.Repositories
{
    public class BookRepository:IBookRepository
    {
        private readonly ILibraryContext _libraryContext;

        public BookRepository(ILibraryContext libraryContext)
        {
            if (libraryContext == null) throw new ArgumentNullException(nameof(libraryContext));
            _libraryContext = libraryContext;
        }

        public int Save(Book book)
        {
            var entity = GetBook(book.Id);
            if (entity != null)
            {
                Map(book, entity);
            }
            {
                _libraryContext.Books.Add(book); 
            }
            _libraryContext.SaveChanges();
            return book.Id;
        }

        public  List<Book> GetAllBooks()
        {
            return _libraryContext.Books.ToList();
        }

        public  Book GetBook(int id)
        {
            return _libraryContext.Books.FirstOrDefault(x => x.Id == id);
        }

        public void Delete(int id)
        {
            var book = GetBook(id);
            _libraryContext.Books.Remove(book);
            _libraryContext.SaveChanges();
        }

        private static void Map(Book book, Book entity)
        {
            entity.Author = book.Author;
            entity.Ibsn = book.Ibsn;
            entity.Publisher = book.Publisher;
            entity.Title = book.Title;
        }
    }
}
