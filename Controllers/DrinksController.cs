using System;
using System.Collections.Generic;
using ExampleOne.Models;
using ExampleOne.Services;
using Microsoft.AspNetCore.Mvc;


namespace ExampleOne.Controllers
{
    public class DrinksController: Controller
    {
        private readonly IDrinksServices DrinksServices;

        public DrinksController(IDrinksServices DrinksServices)
        {
            this.DrinksServices = DrinksServices;
        }


        public IActionResult List()
        {
            ViewBag.x = DrinksServices.GetMyDrinks();
            return View(ViewBag.x);
        }

       
    }
}


