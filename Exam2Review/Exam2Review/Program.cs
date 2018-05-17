using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2Review
{
    class Program
    {

        public abstract class Animal
        {
            public int numberOfLegs;
            public string name;


            //public virtual void Walk()
            //{

            //    Console.WriteLine("I am walking with " + numberOfLegs + " feet. My name is " + name + " .");

            //}

            public abstract void Walk();

        }


        public class Giraffe : Animal
        {
            public Giraffe()
            {
                numberOfLegs = 4;
                name = "LongNeck Giraffe";
            }

            public override void Walk()
            {
                Console.WriteLine("I am walking with " + numberOfLegs + " feet. My name is " + name + " .");
            }
        }

        public class Elephant : Animal
        {
            public Elephant()
            {
                numberOfLegs = 4;
                name = "Fatboy Slim";
            }

            public override void Walk()
            {
                Console.WriteLine("I am walking with " + numberOfLegs + " feet. My name is " + name + " .");
            }
        }

        public class Parrot : Animal
        {
            public Parrot()
            {
                numberOfLegs = 2;
                name = "Parrot TalkAlot";
            }

            public override void Walk()
            {
                Console.WriteLine("I am walking with " + numberOfLegs + " feet. My name is " + name + " .");
            }

        }

        public class Cat : Animal
        {
            public Cat()
            {
                numberOfLegs = 4;
                name = "Cat";
            }

            public override void Walk()
            {
                Console.WriteLine("I am walking with " + numberOfLegs + " feet. My name is " + name + " .");
            }


        }

        static void Main(string[] args)
        {

            Giraffe giraffe = new Giraffe();
            Elephant elephant = new Elephant();
            Parrot parrot = new Parrot();
            Cat cat = new Cat();

            giraffe.Walk();
            elephant.Walk();
            parrot.Walk();
            cat.Walk();
        }
    }
}
