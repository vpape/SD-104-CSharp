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
            this.Health += 2;
            this.AttackPower += 1;
            this.CurrentExp = 0;

        }

        [NotMapped]
        public virtual Weapon Weapon1 { get; set; }
    }
        
}
