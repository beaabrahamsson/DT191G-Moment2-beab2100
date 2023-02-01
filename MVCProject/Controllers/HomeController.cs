using MVCProject.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace MVCProject.Controllers {
    public class HomeController : Controller {
        [Route("/")]
        public IActionResult Index() {
            return View();
        }
        [Route("/om")]
        public IActionResult About() {
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
                }

            }
            return View();

        }
    }
}