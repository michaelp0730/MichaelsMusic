using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Mvc;
using MichaelsMusic.Models;
using Newtonsoft.Json;

namespace MichaelsMusic.Controllers
{
    public class GuitarsController : Controller
    {
        /* Get /guitars/ */
        public ActionResult Index()
        {
            var guitars = GetGuitars();

            return View(new GuitarCollection
            {
                Guitars = guitars.OrderBy(x => x.DisplayName).ToArray()
            });
        }

        /* Get /guitars/{slug}/ */
        public ActionResult Guitar(string slug)
        {
            var guitar = GetGuitars().FirstOrDefault(x => x.Slug == slug);

            return View("~/Views/Guitars/_details.cshtml", guitar);
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