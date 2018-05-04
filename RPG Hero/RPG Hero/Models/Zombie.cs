﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RPGgame
{
   public class Zombie: Monster
    {
        public Zombie()
        {

        }

        public Zombie(int level)
        {

            name = "Zombie";            
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
            Zelda1.Health -= AttackPower;
        }


    }

        
    }

