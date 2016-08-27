using System.Web.Mvc;

namespace MichaelsMusic.Controllers
{
    public class GuitarsController : Controller
    {
        // GET: Guitars
        public ActionResult Index()
        {
            return View();
        }
    }
}