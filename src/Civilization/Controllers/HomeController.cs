using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Civilization.Models;
using Microsoft.AspNetCore.Identity;

namespace Civilization.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DisplayObject()
        {
            Event event = new Event("Commies", "Communist", "Desert", 1);
            return Json(event);
        }

    }
}
