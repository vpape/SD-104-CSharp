using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VernTestMVC.Models
{
    public partial class  Monster
    {


        //public int id { get; set; }
        //public Nullable<int> Health { get; set; }
        //public Nullable<int> Lvl { get; set; }
        //public Nullable<int> AttackPower { get; set; }
        //public string Name { get; set; }
        //public Nullable<byte> Alive { get; set; }

        [NotMapped]
        public virtual Weapon Weapon1 { get; set; }


    }

}

