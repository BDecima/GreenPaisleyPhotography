using System.Web.Mvc;

namespace GreenPaisleyPhotography.Controllers
{
    public class ErrorController : Controller
    {
        //
        // GET: /Error/

        public ActionResult Index()
        {
            return View();
        }

        [ActionName("file-not-found")]
        public ActionResult FileNotFound()
        {
            return View("FileNotFound");
        }
    }
}
