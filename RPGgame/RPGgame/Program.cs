using System;
using System.Collections.Generic;
using System.Text;

namespace RPGgame
{
    class Program
    {
        static void Main(string[] args)
        {
            int CurrentLevel = 1;
            
            

            Hero Zelda = new Hero();
            Monster Sasquatch = new Monster(CurrentLevel);



            while (Zelda.isDead() != true)
            {
                Zelda.Attack(Sasquatch);
                Console.WriteLine("Hero attacks Monster!!");
                Console.ReadLine();

                if (Sasquatch.isDead() == true)
                {

                    Zelda.CurrentExp += 20;
                    Console.WriteLine("Monster is Dead!");
                    Zelda.LevelUp();
                    CurrentLevel++;
                    Console.ReadLine();


                    Sasquatch = new Monster(CurrentLevel);
                    Console.WriteLine("A new monster (LV " + Sasquatch.level + ") appears");
                    Console.ReadLine();

                }
                else
                {
                    Sasquatch.Attack(Zelda);
                    Console.WriteLine("Monster Attacks Hero");
                    Console.ReadLine();
                }

                if(Zelda.isDead() == false)
                {

                    Console.WriteLine("Hero Health: " + Zelda.Herohealth);
                    
                }
                
                                  
                
            }
            Console.WriteLine("Hero is Dead");
            Console.ReadLine();


        }
    }
}
 

