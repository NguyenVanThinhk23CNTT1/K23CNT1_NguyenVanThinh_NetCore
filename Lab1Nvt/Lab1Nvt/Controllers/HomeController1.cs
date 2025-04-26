using Microsoft.AspNetCore.Mvc;

namespace Lab1Nvt.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
