﻿using Microsoft.AspNetCore.Mvc;

namespace LibProject.Controllers
{
    public class HomePageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
