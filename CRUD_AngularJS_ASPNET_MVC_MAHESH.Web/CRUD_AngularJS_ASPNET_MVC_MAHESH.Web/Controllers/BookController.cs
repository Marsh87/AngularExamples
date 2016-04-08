using System;
using System.Web.Mvc;
using CRUD_AngularJS_ASPNET_MVC_MAHESH.Core.Domain;
using CRUD_AngularJS_ASPNET_MVC_MAHESH.Core.Repositories.Interfaces;

namespace CRUD_AngularJS_ASPNET_MVC_MAHESH.Web.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository _bookRepository;
        public BookController(IBookRepository bookRepository)
        {
           if (bookRepository == null) throw new ArgumentNullException(nameof(bookRepository));
            _bookRepository = bookRepository;
        }

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetAllBooks()
        {
            var books = _bookRepository.GetAllBooks();
            return Json(books, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetBookById(string id)
        {
            var bookid = Convert.ToInt32(id);
            var book = _bookRepository.GetBook(bookid);
            return Json(book, JsonRequestBehavior.AllowGet);
        }

        public string SaveBook(Book book)
        {
            if (book == null) return "Invalid book record";
            _bookRepository.Save(book);
            return "Book record added successfully";
        }

        public string DeleteBook(string bookId)
        {
            if (string.IsNullOrEmpty(bookId)) return "Invalid operation";
            var _bookId = Int32.Parse(bookId);
            try
            {
                _bookRepository.Delete(_bookId);
            }
            catch (Exception)
            {
                return "Book details not found";
            }
            return "Invalid operation";
        }

    }
}
