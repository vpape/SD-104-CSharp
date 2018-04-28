using System;
using System.Collections.Generic;
using System.Text;

namespace RPGgame
{
    class Monster
    {
        public int level;
        public int Monsterhealth;
        public int AttackPower;
        public int CurrentExp;

        public Monster(int level)
        {
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

        public bool isDead()
        {
            if (Monsterhealth <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

       

        public void Attack(Hero Zelda1)
        {
            Zelda1.Herohealth -= this.AttackPower;
        }

     
        
    }
}
