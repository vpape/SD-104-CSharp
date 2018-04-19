using System;

namespace Hw_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter which index of the Fibonacci sequence you want the value for: ");
            int index = Int32.Parse(Console.ReadLine());

            int prevNum = 1;
            int currentNum = 0;
            int total = 0;


        
            for (int i = 0; i < index; i++)
            {

                if (i== 0)
                {

                    prevNum = 0;
                    currentNum = 1;

                }

                if (i == 1)
                {

                    prevNum = 0;
                    currentNum = 1;

                }
                              
                total = prevNum + currentNum;
                prevNum = currentNum;
                currentNum = total;
                    
                    
                    

            }
            Console.WriteLine(currentNum);
            Console.Read();
        }
            
    }
 }

