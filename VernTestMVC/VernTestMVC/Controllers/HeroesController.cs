using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VernTestMVC.Models;

namespace VernTestMVC.Controllers
{
    public class HeroesController : Controller
    {
        private RPGGameEntities db = new RPGGameEntities();

        public JsonResult GetHeroes()
        {
            var result = (from h in db.Heroes
                          select new
                          {
                              h.id,
                              h.Health,
                              h.Lvl,
                              h.AttackPower,
                              h.CurrentExp,
                              h.Name,
                              h.Alive
                          });
            return Json(new { data = result }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult LevelUp(int id)
        {
            Hero h = db.Heroes
                        .Where(i => i.id == id)
                        .Single();
            /*h.Lvl += 1;
            h.Health += 50;
            h.AttackPower += 10;
            h.AttackPower += 5;            
            db.SaveChanges();*/

            h.LevelUp();
            db.SaveChanges();


            return Json(new { data = "success" }, JsonRequestBehavior.AllowGet);

        }

        // GET: Heroes
        public ActionResult Index()
        {
            return View(db.Heroes.ToList());
        }

        // GET: Heroes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hero hero = db.Heroes.Find(id);
            if (hero == null)
            {
                return HttpNotFound();
            }
            return View(hero);
        }

        // GET: Heroes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Heroes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Health,Lvl,AttackPower,CurrentExp,Name")] Hero hero)
        {
            if (ModelState.IsValid)
            {
                db.Heroes.Add(hero);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hero);
        }

        // GET: Heroes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hero hero = db.Heroes.Find(id);
            if (hero == null)
            {
                return HttpNotFound();
            }
            return View(hero);
        }

        // POST: Heroes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Health,Lvl,AttackPower,CurrentExp,Name")] Hero hero)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hero).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hero);
        }

        // POST: Heroes/Delete/5
        
        public JsonResult Delete(int id)
        {
            Hero hero = db.Heroes.Find(id);
            db.Heroes.Remove(hero);
            db.SaveChanges();
            var response = (new { response = "success" });
            return Json(response, JsonRequestBehavior.AllowGet);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}