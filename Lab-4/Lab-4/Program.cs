using System;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int largestnumber;
            int smallestnumber;
            int currentnumber;

            Console.Write("Please enter a number (0 to quit) : ");
            currentnumber = Int32.Parse(Console.ReadLine());

            smallestnumber = currentnumber;
            largestnumber = currentnumber;

            while (currentnumber != 0) 
            {
                if (currentnumber > largestnumber)
                {
                    largestnumber = currentnumber;
                }

                if(currentnumber < smallestnumber)
                {
                    smallestnumber = currentnumber;
                }

                Console.Write("Please enter a another number (0 to quit): ");
                currentnumber = Int32.Parse(Console.ReadLine());
            }
            Console.Write("Your smallest number is: " + smallestnumber + "\n");
            Console.Write("Your largest number is: " + largestnumber);
            Console.ReadLine();
        }
    }
}
