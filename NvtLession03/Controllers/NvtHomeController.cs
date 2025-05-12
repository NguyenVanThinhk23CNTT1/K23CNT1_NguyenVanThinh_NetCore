using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NvtLession03.Models;

namespace NvtLession03.Controllers
{
    public class NvtHomeController : Controller
    {
        private readonly ILogger<NvtHomeController> _logger;

        public NvtHomeController(ILogger<NvtHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult NvtIndex()
        {
            return View();
        }

        public IActionResult NvtAbout()
        {
            ViewBag.About = "Văn Thịnh";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult NvtProfile()
        {
            return View();
        }

        public IActionResult NvtRazorCode()
        {
            return View();
        }
    }
}
