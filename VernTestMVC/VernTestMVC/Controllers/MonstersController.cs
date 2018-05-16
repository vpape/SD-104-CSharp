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
    public class MonstersController : Controller
    {
        private RPGGameEntities db = new RPGGameEntities();

        // GET: Monsters
        public ActionResult Index()
        {
            var monsters = db.Monsters.Include(m => m.Weapon);
            return View(monsters.ToList());
        }
        public JsonResult GetMonsters()
        {
            var result = (from m in db.Monsters
                          select new
                          {
                              m.id,
                              m.Health,
                              m.Lvl,
                              m.AttackPower,
                              //m.CurrentExp,
                              m.Name,
                              m.Alive
                          });
            return Json(new { data = result }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult LevelUp(int id)
        {
            Monster m = db.Monsters
                        .Where(i => i.id == id)
                        .Single();
            /*h.Lvl += 1;
            h.Health += 50;
            h.AttackPower += 10;
            h.AttackPower += 5;            
            db.SaveChanges();*/

            //m.LevelUp();
            db.SaveChanges();


            return Json(new { data = "success" }, JsonRequestBehavior.AllowGet);

        }


        // GET: Monsters/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Monster monster = db.Monsters.Find(id);
            if (monster == null)
            {
                return HttpNotFound();
            }
            return View(monster);
        }

        // GET: Monsters/Create
        public ActionResult Create()
        {
            ViewBag.WeaponId = new SelectList(db.Weapons, "id", "Name");
            return View();
        }

        // POST: Monsters/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Health,Lvl,AttackPower,Name,Alive,WeaponId")] Monster monster)
        {
            if (ModelState.IsValid)
            {
                db.Monsters.Add(monster);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.WeaponId = new SelectList(db.Weapons, "id", "Name", monster.WeaponId);
            return View(monster);
        }

        // GET: Monsters/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Monster monster = db.Monsters.Find(id);
            if (monster == null)
            {
                return HttpNotFound();
            }
            ViewBag.WeaponId = new SelectList(db.Weapons, "id", "Name", monster.WeaponId);
            return View(monster);
        }

        // POST: Monsters/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Health,Lvl,AttackPower,Name,Alive,WeaponId")] Monster monster)
        {
            if (ModelState.IsValid)
            {
                db.Entry(monster).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.WeaponId = new SelectList(db.Weapons, "id", "Name", monster.WeaponId);
            return View(monster);
        }

        // GET: Monsters/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Monster monster = db.Monsters.Find(id);
            if (monster == null)
            {
                return HttpNotFound();
            }
            return View(monster);
        }

        // POST: Monsters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Monster monster = db.Monsters.Find(id);
            db.Monsters.Remove(monster);
            db.SaveChanges();
            return RedirectToAction("Index");
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
