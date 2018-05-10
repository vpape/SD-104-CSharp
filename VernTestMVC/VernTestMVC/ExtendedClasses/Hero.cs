using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace VernTestMVC.Models
{
    public partial class Hero
    {
        public void LevelUp()
        {
            this.Lvl += 1;
            this.Health += 20;

        }

        [NotMapped]
        public Weapon HeroWeapon { get; set; }

       
    }
}