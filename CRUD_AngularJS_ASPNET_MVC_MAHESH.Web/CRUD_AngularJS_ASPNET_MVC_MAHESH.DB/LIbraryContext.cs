using System;
using System.Data.Entity;
using CRUD_AngularJS_ASPNET_MVC_MAHESH.Core.Domain;

namespace CRUD_AngularJS_ASPNET_MVC_MAHESH.DB
{
    public interface ILibraryContext:IDisposable
    {
        DbSet<Book> Books { get; set; }
        int SaveChanges();
    }

    public class LibraryContext:DbContext,ILibraryContext
    {
        public DbSet<Book> Books { get; set; }

    }
}
