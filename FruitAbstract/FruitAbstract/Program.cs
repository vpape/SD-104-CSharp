using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitAbstract
{
    class Program
    {
      

        static void Main(string[] args)
        {
            Basket basket = new Basket();
            Banana banana = new Banana();
            Mango mango = new Mango();
            Apple apple = new Apple();

            basket.AddFruit(mango);
            basket.AddFruit(banana);
            basket.AddFruit(apple);
            basket.Throw(apple);
            basket.DisplayFruit();

            

        }
    }
}
