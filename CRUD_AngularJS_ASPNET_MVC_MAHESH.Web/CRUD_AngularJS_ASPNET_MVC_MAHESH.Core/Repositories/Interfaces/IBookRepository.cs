using System.Collections.Generic;
using CRUD_AngularJS_ASPNET_MVC_MAHESH.Core.Domain;

namespace CRUD_AngularJS_ASPNET_MVC_MAHESH.Core.Repositories.Interfaces
{
    public interface IBookRepository
    {
          int Save(Book book);
         List<Book> GetAllBooks();
          Book GetBook(int id);
          void Delete(int id);
    }
}