using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VernTestMVC.Models
{
    public partial class Weapon
    {
        public void LevelUp()
        {
            this.Name += 1;
            this.AttackValue += 5;
            this.AttackModifier += 1;
            this.Hands = Hands;
        }

            public virtual Weapon Weapon1 { get; set; }

    }
}
