using Microsoft.AspNetCore.Mvc;
using Pigeons4all.Models;
using System.Diagnostics;

namespace Pigeons4all.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();

        public IActionResult Auction() => View();

        public IActionResult Pigeon() => View();
    }
}