using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using MichaelsMusic.Models;
using Newtonsoft.Json;

namespace MichaelsMusic.Controllers
{
    public class GuitarsController : Controller
    {
        [Route("/guitars/")]
        public ActionResult Index()
        {
            var guitars = GetGuitars();

            return View(new GuitarCollection
            {
                Guitars = guitars.OrderBy(x => x.DisplayName).ToArray()
            });
        }

        private List<Guitar> GetGuitars()
        {
            var guitars = new List<Guitar>();

            using (StreamReader sr = new StreamReader(Server.MapPath("~/JSON/guitars.json")))
            {
                guitars = JsonConvert.DeserializeObject<List<Guitar>>(sr.ReadToEnd());
            }

            return guitars;
        }
    }
}