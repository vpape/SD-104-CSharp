using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RPGgame;

namespace RPG_Hero.Controllers
{
    public class HeroesController : Controller
    {
        private RPG_HeroContext context = new RPG_HeroContext();

        // GET: Heroes
        public ActionResult Index()
        {
            return View(context.ToList());
        }

        // GET: Heroes/Details/5
        public ActionResult Details(int id)
        {
            
            RPG_HeroContext context = new RPG_HeroContext();
            Hero hero = context.GetHeroById(id);            
            return View(hero);

            /*Hero hero = context.GetHeroById(id);
            return View(hero);*/
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
        public ActionResult Create([Bind(Include = "Id,Lvl,Health,AttackPower,CurrentExp")] Hero hero)
        {
            if (ModelState.IsValid)
            {
                context.Add(hero);
                                
                return RedirectToAction("Index");
            }

            return View(hero);
        }

        // GET: Heroes/Edit/5
        public ActionResult Edit(int id)
        {
           
            return View();
        }

        // POST: Heroes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Lvl,Health,AttackPower,CurrentExp")] Hero hero)
        {
            hero.Health = Int32.Parse(Request.Form["Health"].ToString());

            RPG_HeroContext context = new RPG_HeroContext();
            context.EditById(hero);
            return RedirectToAction("Index");                 
            
        }

        // GET: Heroes/Delete/5
        public ActionResult Delete(int id)
        {
            RPG_HeroContext context = new RPG_HeroContext();
            Hero hero = context.GetHeroById(id);
            return View(hero);

            
        }

        // POST: Heroes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            
            RPG_HeroContext context = new RPG_HeroContext();            
            context.Delete(id);            
            return RedirectToAction("Index");
        }

      
    }
}
