using System;

namespace HandsOn
{
    class Program
    {
        static int FindMax(int[] param)
        {
            int max = param[0];

            for (int i = 0; i < param.Length; i++)
            {
                if (max < param[i])
                {
                    max = param[i];
                }

            }
            return max;

        }


        static float FindAvg(float[] avg)
        {
            float NumAvg = 0;

            for (int i = 0; i < avg.Length; i++)
            {
                NumAvg += avg[i];

            }
            NumAvg /= avg.Length;
            return NumAvg;
        }

        static void Main(string[] args)
        {
            int[] array1 = { 1, 4, 6, 1, 3, 9, 0, -1, -6, 11 };
            int[] array2 = { -9, -7 - 5, -11, -7, -88, -5, -10 };


            Console.WriteLine("Maximum: " + FindMax(array1));
            Console.WriteLine();
            Console.WriteLine("Maximum2: " + FindMax(array2));

            float[] avg1 = { 1, 2, 3, 4, 5, 6, 8, 10 };
            Console.WriteLine("Avg: " + FindAvg(avg1));

            int x = 100;
            int y = 200;
            int z = 101;
            int xz = x + z;
            int yz = y + z;
            int sum = x + y + z;
            int num = x - 1 + z;

            string name = "just a test";


            if (xz > y)
            {
                Console.WriteLine(xz + "> " + y);
            }
            else
            {
                Console.WriteLine(xz + "< " + y);
            }

            if (num == y)
            {
                Console.WriteLine(num + "= " + y);
            }
            else
            {
                Console.WriteLine(num + "!= " + y);
            }


            if (sum < yz)
            {
                Console.WriteLine(sum + "< " + yz);

            }
            else
            {
                Console.WriteLine(sum + "> " + yz);
            }

            if (name.Contains("test"))
            {
                Console.WriteLine("String contains test- " + name + ": " + name.Substring(8, 11));
            }
            else
            {
                Console.WriteLine("String does not contain test in it ");
            }

            if (name.Length > 12)
            {
                Console.WriteLine("String is longer than 12 characters: " + name);
            }
            else if (name.Length == 12)

            {
                Console.WriteLine("String is equal to 12: " + name.Length);
            }

        }
                       
    }
}


















