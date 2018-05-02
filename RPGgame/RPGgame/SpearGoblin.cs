using System;
using System.Collections.Generic;
using System.Text;

namespace RPGgame
{
    class SpearGoblin: Goblin
    {

        public SpearGoblin(int level)
        {

            name = "Spear Goblin";
            range = level * 2;
            if (level == 1)
            {
                AttackPower = 1;

            }
            else
            {
                AttackPower = level * 2;

            }
            Monsterhealth = 2 * level;
            this.level = level;
        }


        public override void Attack(Hero Zelda1)
        {
            Zelda1.Herohealth -= AttackPower + range;
        }


    }

        
    }

