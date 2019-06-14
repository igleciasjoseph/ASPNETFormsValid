using Microsoft.AspNetCore.Mvc;
using FormValid.Models;
namespace FormValid.Controllers
{
    public class IndexController : Controller {
        [HttpGet("")]
        public ViewResult Index() {
            return View();
        }

        [HttpPost("create")]
        public IActionResult Create(User u) {
            if(ModelState.IsValid) {
                return RedirectToAction("Success");
            }
            else {
                return View("Index");
            }
        }

        [HttpGet("success")]
        public ViewResult Success() {
            return View();
        }
    }
}