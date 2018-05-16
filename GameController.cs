using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EricsTestMVC.Models;

namespace EricsTestMVC.Controllers
{
    public class GameController : Controller
    {
        private RPGGameEntities db = new RPGGameEntities();

        // GET: Game
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NewGame()
        {
            return View();
        }

        public ActionResult Edit()
        {
            return View();
        }

        public JsonResult GameStart(string Name)
        {
            Hero h = new Hero();
            h.Name = Name;
            h.LVL = 1;
            h.Health = 20;
            h.CurrentEXP = 0;
            h.Alive = 1;

            Weapon w = db.Weapons
                        .Where(i => i.Name == "Rusty Sword")
                        .SingleOrDefault();

            h.Weapon1 = w;
            db.Heroes.Add(h);
            db.SaveChanges();

            Monster m = new Monster();
            m.Alive = 1;
            m.AttackPower = 0;
            m.EXP = 5;
            m.Health = 10;
            m.LVL = 1;
            m.Name = "Goblin";
            m.Weapon1 = w;

            var result = (new
            {
                Hero = new
                {
                    h.ID,
                    h.Name,
                    h.Health,
                    h.LVL,
                    h.AttackPower,
                    h.CurrentEXP,
                    //h.Alive,
                    Weapon = new { w.Name, w.AttackValue, w.AttackModifier }
                },
                Monster = new
                {
                    m.Name,
                    m.Health,
                    m.AttackPower,
                    m.EXP,
                    m.LVL,
                    Weapon = new { m.Weapon1.Name, m.Weapon1.AttackValue, m.Weapon1.AttackModifier }
                }
            });

            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public JsonResult LevelUp(string Name)
        {

            Hero h = db.Heroes
                        .Where(i => i.Name == Name)
                        .SingleOrDefault();

            h.LevelUp();
            db.SaveChanges();

            return Json(h, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Attack(int AttackValue, int AttackPower, int AttackModifier, int MAttackValue, int MAttackPower, int MAttackModifier)
        {
            Random rnd = new Random();
            int Attack = rnd.Next(1, AttackValue+AttackPower+1);

            Attack += AttackModifier;

            int MAttack = rnd.Next(1, MAttackValue + MAttackPower + 1);

            MAttack += MAttackModifier;

            return Json(new { HAttack = Attack, MAttack = MAttack }, JsonRequestBehavior.AllowGet);
        }
    }
}