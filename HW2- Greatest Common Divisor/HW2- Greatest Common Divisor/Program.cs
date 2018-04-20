using System;

namespace HW2__Greatest_Common_Divisor
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;


            Console.Write("Please enter an Integer to divide: ");
            // string input = Console.ReadLine();
            //while (Int32.TryParse(input, out num1) == false) ;

            while (Int32.TryParse(Console.ReadLine(), out num1) == false)
            {

                Console.WriteLine("this is not an integer. Give me an integer: ");
                //input = Console.ReadLine();

            }

            Console.Write("Please enter a second Integer to divide: ");
            // string input = Console.ReadLine();
            //while (Int32.TryParse(input, out num1) == false) ;

            while (Int32.TryParse(Console.ReadLine(), out num2) == false) 
            {
                Console.WriteLine("this is not an integer. Give me an integer: ");
                //input = Console.ReadLine();

            }

            if (num1 >= num2)
            {
                while (num1 % num2 != 0)
                {

                    int remainder = num1 % num2;
                    num1 = num2;
                    num2 = remainder;

                }
                Console.WriteLine(num2 + " is the GCD");
            }
            else if (num2 >= num1)
            {
                while (num2 % num1 != 0)
                    
                {
                    int remainder = num2 % num1;
                    num2 = num1;
                    num1 = remainder;
                    
                }
                Console.WriteLine(num1 + " is the GCD");
            }
            
            Console.Read();

        }
    }
}
