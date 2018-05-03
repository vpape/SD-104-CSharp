using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RPGgame;

namespace MonsterWebProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            List<Monster> Goons = new List<Monster>();
            Random random = new Random();
            Monster theMonster = new Goblin(5);
            

            for (int i = 0; i < 10; i++)
            {
                
                int randomNum = random.Next(1, 7);
                                    
                    if (randomNum == 1)
                    theMonster = new Goblin(5);

                    if (randomNum == 2)
                    theMonster = new SpearGoblin(4);

                    if (randomNum == 3)
                    theMonster = new Zombie(3);

                    if (randomNum == 4)
                    theMonster = new ZombieArcher(6);

                    if (randomNum == 5)
                    theMonster = new Skeleton(7);

                    if (randomNum == 6)
                    theMonster = new Goblin(5);

                Goons.Add(theMonster);

            }
            
            return View(Goons);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}