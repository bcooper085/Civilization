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

        //public IActionResult DisplayObject()
        //{
        //    Event event = new Event("Flood", "Your city is dead", 1);
        //    return Json(event);
        //}

        //public IActionResult DisplayViewWithAjax()
        //{
        //    return View();
        //}

        //public IActionResult RandomEventList(int eventCount)
        //{
        //    var randomEventList = db.Events.OrderBy(r => Guid.NewGuid()).Take(eventCount);
        //    return Json(randomEventList);
        //}

        //[HttpPost]
        //public IActionResult NewEvent(string newCity, string newCountry)
        //{
        //    Destination newDestination = new Models.Destination(newCity, newCountry);
        //    db.Destinations.Add(newDestination);
        //    db.SaveChanges();
        //    return Json(newDestination);
        //}
    }
}
