using System.Web.Mvc;

namespace LuceMIS4200_940.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "My MIS4200 Test Description.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Info about ME.";

            return View();
        }
    }
}