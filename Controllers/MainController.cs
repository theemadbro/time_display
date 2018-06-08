using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace time_display.Controllers
{
    public class MainController:Controller
    {
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}