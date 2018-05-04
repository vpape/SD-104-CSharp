using System;
using System.Collections.Generic;
using System.Text;

namespace RPGgame
{
    public class Hero
    {
        public int Id { get; set; }
        public int Lvl { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public int CurrentExp { get; set; }


        public Hero()
        {
            Health = 5;
            AttackPower = 2;
            CurrentExp = 0;
            Lvl = 1;

        }


        public bool isDead()
        {
            if(Health <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

      


        public void Attack(Monster monster)
        {
            monster.Monsterhealth -= this.AttackPower;

        }

       

        public void LevelUp()
        {
            int timesToLevel = this.CurrentExp / 40;
            if(timesToLevel > 0)
            {
                Lvl += timesToLevel;
                Console.WriteLine("Hero Level Up: New Level: " + this.Lvl);
                AttackPower += timesToLevel * 5;
                Health += 3 * Lvl;
                this.CurrentExp -= timesToLevel * 40;
                Console.ReadLine();
            }
        }
    }
}
