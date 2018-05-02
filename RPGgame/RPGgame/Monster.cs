using System;
using System.Collections.Generic;
using System.Text;

namespace RPGgame
{
    abstract class Monster
    {
        public int level;
        public int Monsterhealth;
        public int AttackPower;
        public int range;
        public string name;


        public abstract void Attack(Hero Zelda1);
       

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

       

      

     
        
    }
}
