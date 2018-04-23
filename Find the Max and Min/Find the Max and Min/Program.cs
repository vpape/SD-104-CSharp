using System;

namespace Find_the_Max_and_Min
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program is going to take user input - Number of numbers he is going to write
            //Program is going to validate user input and make sure it's an number
            //Program is going to loop and have user write a number up to the  (size / number of numbers)
            //Program is going to find the Max number and Min number in the array
            //Program will output this to the user

            //hint #1
            //use if statement for min[position] and max[position]
            //min = array[position]
            //hint #2--do not do in loop
            //min and max is going to start as the first value in your array. so array[0]

            //hint #3
            //min means array[position] < min
            //max means array[position] > max


            Console.WriteLine("Please enter how many values you want in your array: ");
            int input;

            while (Int32.TryParse(Console.ReadLine(), out input) == false)
            {
                Console.Write("Not a number, please enter the values");
            }

            int[] number = new int[input];
            for (int i = 0; i < number.Length; i++)
            {
                Console.Write("Please enter the value for number " + (i+ 1) + ": ");
                while (Int32.TryParse(Console.ReadLine(), out input) == false)
                {
                   Console.Write("Not a number, Please enter a number");
                   
                }
                number[i] = input;
            }

            int min = number[0];
            int max = number[0];

            for (int i = 0; i < number.Length; i++)
            {

                if (max < number[i])
                {
                    max = number[i];
                }

                if (min > number[i])
                {
                    min = number[i];
                }
                               
            }
            
            Console.WriteLine("The maximum is: " + max);
            Console.WriteLine("The minimum is: " + min);
            Console.Read();

            
        }
    }
}
