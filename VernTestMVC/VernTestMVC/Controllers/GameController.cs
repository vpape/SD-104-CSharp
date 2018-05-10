using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VernTestMVC.Models;

namespace VernTestMVC.Controllers
{
    public class GameController : Controller
    {
        private RPGGameEntities db = new RPGGameEntities();

        // GET: Game
        public ActionResult Index()
        {
            return View();
        }


        public JsonResult GameStart(String Name)
        {
            Hero h = new Hero();
            h.Name = Name;
            h.Lvl = 1;
            h.Health = 20;
            h.CurrentExp = 0;
            h.Alive = 1;

            db.Heroes.Add(h);
            db.SaveChanges();

            return Json(h, JsonRequestBehavior.AllowGet);


        }
        public JsonResult LevelUp(String Name)
        {
            Hero h = db.Heroes
                .Where(i => i.Name == Name)
                .SingleOrDefault();


            db.Heroes.Add(h);
            db.SaveChanges();

            return Json(h, JsonRequestBehavior.AllowGet);

        }

    }
}

