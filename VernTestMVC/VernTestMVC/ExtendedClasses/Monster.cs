using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VernTestMVC.Model
{
    public class Monster
    {
        public void LevelUp()
        {
            this.Lvl += 1;
            this.Health += 20;

        }

        [NotMapped]
        public Weapon Monster { get; set; }




    }
}
