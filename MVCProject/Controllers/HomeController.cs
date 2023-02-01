using Microsoft.AspNetCore.Mvc;

namespace MVCProject.Controllers {
    public class HomeController : Controller {
        public IActionResult Index() {
            return View();
        }

        public IActionResult About() {
            return View();
        }

        public IActionResult Books() {
            return View();
        }
    }
}