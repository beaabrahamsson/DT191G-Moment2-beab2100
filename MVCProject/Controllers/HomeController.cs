using MVCProject.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace MVCProject.Controllers {
    public class HomeController : Controller {
        [Route("/")]
        public IActionResult Index() {
            var JsonStr = System.IO.File.ReadAllText("books.json");
            var JsonObj = JsonConvert.DeserializeObject<List<BookModel>>(JsonStr);
            return View(JsonObj);
        }
        [Route("/om")]
        public IActionResult About() {
            ViewBag.Title = "Om sidan";
            ViewData["Description"] = "Detta är en webbplats skapad för Moment 2 i kursen Webbutveckling med .NET. Webbplatsen är skapad med ASP.net Core och bygger på MVC-designmönstret.";
            ViewData["Contact"] = "Webbplatsen är skapad av Beatrice Abrahamsson. Kontakta mig via e-post på beab2100@student.miun.se";
            return View();
        }
        [Route("/bocker")]
        public IActionResult Books() {
            return View();
        }

        [HttpPost("/bocker")]
        public IActionResult Books(BookModel model) {
            if(ModelState.IsValid) {
                var JsonStr = System.IO.File.ReadAllText("books.json");
                var JsonObj = JsonConvert.DeserializeObject<List<BookModel>>(JsonStr);

                if(JsonObj != null) {
                    JsonObj.Add(model);
                    System.IO.File.WriteAllText("books.json", JsonConvert.SerializeObject(JsonObj, Formatting.Indented));

                    ModelState.Clear();

                    //return RedirectToAction("Index", "Home");
                }

            }
            return View();

        }
    }
}