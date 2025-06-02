using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NvtLession07.Models;

namespace NvtLession07.Controllers
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
