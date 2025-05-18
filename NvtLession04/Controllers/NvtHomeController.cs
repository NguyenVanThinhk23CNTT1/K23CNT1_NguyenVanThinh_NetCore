using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NvtLession04.Models;

namespace NvtLession04.Controllers
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
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
