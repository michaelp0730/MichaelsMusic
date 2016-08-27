using System.Collections.Generic;
using System.IO;
using System.Web.Mvc;
using MichaelsMusic.Models;
using Newtonsoft.Json;

namespace MichaelsMusic.Controllers
{
    public class GuitarsController : Controller
    {
        // GET: Guitars
        public ActionResult Index()
        {
            var guitars = new List<Guitar>();

            using (StreamReader sr = new StreamReader(Server.MapPath("~/JSON/guitars.json")))
            {
                guitars = JsonConvert.DeserializeObject<List<Guitar>>(sr.ReadToEnd());
            }

            return View(new GuitarCollection
            {
                Guitars = guitars.ToArray()
            });
        }
    }
}