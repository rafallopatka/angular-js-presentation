using System.Web.Mvc;

namespace Presentation.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SetList()
        {
            return View();
        }
    }
}