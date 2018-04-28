using System;
using System.Collections.Generic;
using System.Text;

namespace RPGgame
{
    class Hero
    {
        public int level;
        public int Herohealth;
        public int AttackPower;
        public int CurrentExp;


        public Hero()
        {
            Herohealth = 5;
            AttackPower = 2;
            CurrentExp = 0;
            level = 1;

        }


        public bool isDead()
        {
            if(Herohealth <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

      


        public void Attack(Monster Sasquatch1)
        {
            Sasquatch1.Monsterhealth -= this.AttackPower;
        }

       

        public void LevelUp()
        {
            int timesToLevel = this.CurrentExp / 40;
            if(timesToLevel > 0)
            {
                level += timesToLevel;
                Console.WriteLine("Hero Level Up: New Level: " + this.level);
                AttackPower += timesToLevel * 5;
                Herohealth += 3 * level;
                this.CurrentExp -= timesToLevel * 40;
            }
        }
    }
}
