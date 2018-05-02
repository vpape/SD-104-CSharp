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
            Monster monster = new Goblin(CurrentLevel);
            
            Console.WriteLine("Monster {0} - (LV{1}) appears.", monster.name, monster.level);
            Random random = new Random();
            

            while (Zelda.isDead() != true)
            {
                Zelda.Attack(monster);
                Console.WriteLine("Hero attacks Monster!!");
                Console.ReadLine();

                if (monster.isDead() == true)
                {
                    
                    Zelda.CurrentExp += 20;
                    Console.WriteLine("Monster is Dead!");
                    Zelda.LevelUp();
                    CurrentLevel++;
                    int randomNum = random.Next(1, 7);

                    if (randomNum == 1)
                        monster = new Goblin(CurrentLevel);
                    if (randomNum == 2)
                        monster = new SpearGoblin(CurrentLevel);
                    if (randomNum == 3)
                        monster = new Skeleton(CurrentLevel);
                    if (randomNum == 4)
                        monster = new Zombie(CurrentLevel);
                    if (randomNum == 5)
                        monster = new ZombieArcher(CurrentLevel);
                    if (randomNum == 6)
                        monster = new HoodedGoblin(CurrentLevel);
                                      

                                        
                    Console.WriteLine("Monster {0} - (LV{1}) appears.", monster.name, monster.level);
                    Console.ReadLine();

                }
                else
                {
                    monster.Attack(Zelda);
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
 

