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

        public ActionResult NewGame()
        {
            return View();
        }

        public ActionResult Edit()
        {
            return View();
        }


        public JsonResult GameStart(String Name)
        {
            Hero h = new Hero();

            h.Name = Name;
            h.Lvl = 1;
            h.Health = 100;
            h.CurrentExp = 0;
            h.Alive = 1;
            h.AttackPower = 0;


            Weapon w = db.Weapons

                .Where(i => i.Name == "Knife")
                .SingleOrDefault() ?? new Weapon { Name = "Rusty Lance", AttackValue = 5, AttackModifier = 2, Hands = 1};

            h.Weapon1 = w;
            db.Heroes.Add(h);
            db.SaveChanges();

            Monster m = new Monster();
            m.Alive = 1;
            m.AttackPower = 0;            
            m.Health = 100;
            m.Lvl = 1;
            m.Name = "Hulk";
            m.Weapon1 = w;

            var result = (new
            {
                Hero = new
                {
                    h.id,
                    h.Name,
                    h.Lvl,
                    h.Health,
                    h.AttackPower,
                    h.CurrentExp,

                    Weapon = new { w.Name, w.AttackValue, w.AttackModifier }
                },

                Monster = new
                {
                    m.id,
                    m.Name,
                    m.Lvl,
                    m.Health,
                    m.AttackPower,
                    Weapon = new { m.Weapon1.Name, m.Weapon1.AttackValue, m.Weapon1.AttackModifier }

                }
            }
                );


            return Json(result, JsonRequestBehavior.AllowGet);


        }


        public JsonResult LevelUp(String Name)
        {
            Hero h = db.Heroes

                .Where(i => i.Name == Name)
                .SingleOrDefault();

            h.LevelUp();

            
            db.Heroes.Add(h);
            db.SaveChanges();

            return Json(h, JsonRequestBehavior.AllowGet);

        }

       

        public JsonResult Attack(int AttackValue, int AttackPower, int AttackModifier, int MAttackValue, int MAttackPower, int MAttackModifier)
        {
            Random rand = new Random();
            int Attack = rand.Next(1, AttackValue + AttackPower + 1);

            Attack += AttackModifier;

            int MAttack = rand.Next(1, MAttackValue + MAttackPower + 1);

            MAttack += MAttackModifier;
                
            return Json(new { HAttack = Attack, MAttack = Attack },JsonRequestBehavior.AllowGet);

        }
    }
}


//Order of building app
//    1. DB Table
//    2. EF Add/Update
//    3. Extend partial classes
//    4. Create controllers
//    5. UserInterface (JvaScrpt & HTML)
