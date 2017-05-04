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
        private ApplicationDbContext db = new ApplicationDbContext();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DisplayObject()
        {
            Game game = new Game("Commies", "Communist", "Desert", 1);
            return Json(game);
        }

        public IActionResult RandomEventList(int eventStart)
        {
            var randomEventList = db.Events.OrderBy(r => Guid.NewGuid()).Take(eventStart);
            return Json(randomEventList);
        }

        public IActionResult GameStart(string name, string govList, string geogList)
        {
            Game game = new Game(name, govList, geogList);
            db.Games.Add(game);
            db.SaveChanges();
            return Json(game);
        }
    }
}
