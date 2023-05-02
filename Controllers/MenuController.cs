using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ExampleOne.Models;
using ExampleOne.Services;

namespace ExampleOne.Controllers
{
    public class MenuController : Controller
    {
        private readonly IDrinksServices DrinksServices;

        private readonly ILogger<MenuController> _logger;

        public MenuController(ILogger<MenuController> logger, IDrinksServices DrinksServices)
        {
            _logger = logger;
            this.DrinksServices = DrinksServices;

        }

        public IActionResult Index()
        {
            return View(DrinksServices.GetMyDrinks());

        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
            }

            public IActionResult Options()
        {
            return View(DrinksServices.GetMyDrinks());
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
