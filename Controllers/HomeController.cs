﻿using Microsoft.AspNetCore.Mvc;

namespace MVC02.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult AboutUs()
        {
            return View ();
        }


        public IActionResult ContactUS()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
