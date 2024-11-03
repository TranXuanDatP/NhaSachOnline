using Microsoft.AspNetCore.Mvc;
using Nhà_sách_Online.Models;
using Nhà_sách_Online.Models.DTOS;
using Nhà_sách_Online.Respositories;
using System.Diagnostics;

namespace Nhà_sách_Online.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index() { 
            return View();
        }

        public IActionResult Privacy()
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
