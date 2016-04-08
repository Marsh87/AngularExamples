using AnuglarMVC.Models;
using System.Linq;
using System.Web.Mvc;

namespace AnuglarMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public JsonResult GetStudents()
        {
            SchoolEntities dbContext = new SchoolEntities();
            var result = dbContext.Students.ToList();
            return Json(result, JsonRequestBehavior.AllowGet);

        }
    }
}