using Microsoft.AspNetCore.Mvc;

namespace MVCProject.Controllers {
    public class HomeController : Controller {
        public IActionResult Index() {
            return View();
        }
        [Route("/om")]
        public IActionResult About() {
            return View();
        }

        public IActionResult Books() {
            return View();
        }
    }
}