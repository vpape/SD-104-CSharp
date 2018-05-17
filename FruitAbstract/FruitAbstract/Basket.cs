using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitAbstract
{
    public class Basket : Fruit
    {
        

        //List<Fruit> Fruits;
        private List<Fruit> fruits;



        public Basket()
        {
            fruits = new List<Fruit>();
        }

        public void Throw(Fruit fruit)
        {
            fruits.Remove(fruit);
        } 

        public void DisplayFruit()
        {
            for (int i = 0; i < fruits.Count; i++)
            {
                Console.WriteLine(fruits[i].name);
                
            }

        }
       
       public void AddFruit(Fruit fruit)
        {
            fruits.Add(fruit);
        }
        
        
    }
}
