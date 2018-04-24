using System;

namespace Modulo_Function
{
    class Program
    {
     
        public static void Main()
        {
            int number;
            int random= RandomNumber(1,5);
           

            bool playAgain = true;
            while(playAgain == true)
            {
                number = InputNumber();
                //wite the logic that will check if you got the number or if you're too high or too low
                if (number > random)
                {
                    Console.WriteLine("Too high ");
                }
                else if (number < random) 
                    
                {
                    Console.WriteLine("Too low ");
                }

                else if(number == random)
                {
                    Console.WriteLine("You win. Play again?");
                    string input = Console.ReadLine();

                    if (input.ToUpper() == "Y")
                    {
                        playAgain = true;
                        random = RandomNumber(1,5);
                    }
                    else
                    {
                        playAgain = false;

                    }

                  
                }

               
                

              
            }
           
        }

        private static int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        private static int InputNumber()
        {
            int input;
            Console.Write("Hey You! Give me a number! ");
            while(Int32.TryParse(Console.ReadLine(),out input) == false)
            {
                Console.WriteLine("Not a number. Give me a number: ");
            }
            return input;


        }
            

        }
        
      

    }

