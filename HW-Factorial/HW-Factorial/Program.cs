using System;

namespace HW_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int userinput;
            int total = 1;


            Console.WriteLine("Enter number to factor: ");
            while (Int32.TryParse(Console.ReadLine(), out userinput) == false)

            {
                Console.WriteLine("Give me actual number: ");
                          
            }

            for (int i = userinput; i > 0; i--)
            {
                total *= i;

                if( i > 1)
                Console.Write(i+ "x");
                else
                {
                    Console.WriteLine(i);
                }
            }
            
            Console.Read();

        }
    }
}


