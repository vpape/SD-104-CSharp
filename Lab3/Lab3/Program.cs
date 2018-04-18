using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight;
            double height;

            Console.WriteLine("Enter your weight pounds: ");
            weight = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter your height inches: ");
            height = Int32.Parse(Console.ReadLine());

            

            double BMI = (weight * 703) / (height * height);
            

            if(BMI < 18.5)
            {
                Console.WriteLine("Your BMI is: " + BMI);
                Console.WriteLine("Underweight");                

            }

            else if (BMI >= 18.5 && BMI <= 25)
            {
                Console.WriteLine("Your BMI is: " + BMI);
                Console.WriteLine("Normal");
              

            }

            else if (BMI >= 25 && BMI <= 29.9)
            {
                Console.WriteLine("Your BMI is: " + BMI);
                Console.WriteLine("Overweight");       


            }

            else
            {
                Console.WriteLine("Your BMI is: " + BMI);
                Console.WriteLine("Obese");
                


            }

            Console.Read();


        }
    }
}
