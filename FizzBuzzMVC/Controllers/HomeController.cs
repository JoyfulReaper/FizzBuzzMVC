using FizzBuzzMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzzMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult FizzBuzz()
        {
            FizzBuzzModel fizzbuzz = new FizzBuzzModel();

            fizzbuzz.FizzValue = 3;
            fizzbuzz.BuzzValue = 5;

            return View(fizzbuzz);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult FizzBuzz(FizzBuzzModel fizzbuzz)
        {

            return View(fizzbuzz);
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
