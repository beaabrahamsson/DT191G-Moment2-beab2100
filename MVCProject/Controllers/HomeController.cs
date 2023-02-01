using Microsoft.AspNetCore.Mvc;

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
        [Route("/books")]
        public IActionResult Books() {
            return View();
        }
    }
}