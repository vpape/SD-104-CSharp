using System;

namespace MakingChange
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator();
            Console.ReadLine();
        }

        private static void ChangeDriver()
        { 
            string exit = "";
            Random rnd = new Random();
            do
            {
                int intPrice = rnd.Next(1, 100);
                decimal price = (decimal)intPrice / 100.00M + rnd.Next(10);
                int tendered = rnd.Next((int)price, (int)price + rnd.Next(20));
                string change = MakingChange(tendered, price);
                exit = GetUserInput(change);
            } while (!exit.Equals("x"));
            
        }

        private static string MakingChange(int tendered, decimal price)
        {
            int quarters, dimes, nickels, cents;
            decimal change = tendered - price;
            

            quarters = (int) (change / .25m);
            change -=  quarters * .25m;

            dimes = (int)(change / .10m);
            change -=  dimes * .10m;

            nickels =  (int)(change / .05m);
            change -=  nickels * .05m;

            cents = (int)(change / .01m);

            return String.Format("Change from {4:F2 for {5:F2}\n\tQ {0} D {1} N {2} C {3}", quarters, dimes, nickels, cents, tendered, price);
        }

        private static string GetUserInput(string prompt)
        {
            Console.Write(prompt);
            string str = Console.ReadLine();
            return str;
        }


        private static void Calculator()
        {
            double num1, num2 = 0;
            while (true) {

                string str = GetInput("Enter Equation: ");
                string[] strArray = str.Split(' ');
                num1 = GetNumber(strArray[0]);
                if (strArray.Length == 3)
                    num2 = GetNumber(strArray[2]);
                double answer = GetAnswer(strArray[1], num1, num2);
                if (strArray.Length == 3)
                    Console.WriteLine("{0:F2} = {1:F2} {2:F2} {3:F2}", answer, num1, strArray[1], num2);
                else
                    Console.WriteLine("{0:F2} = {1:F2} {2:F2}", answer, num1, strArray[1]);


                Console.WriteLine("{0} = {1} {2} {3}", answer, num1, strArray[1], num2);
                Console.ReadLine();
            }
        }

        public static string GetInput(string prompt)
        {
            Console.Write(prompt);
            string str = Console.ReadLine();
            return str;
        }

        public static double GetNumber(string strNum)
        {
            double dblNum;
            double.TryParse(strNum, out dblNum);
            return dblNum;
        }

        public static double GetAnswer(string op, double num1, double num2)
        {
            double answer = 0;
            switch (op)
            {
                case "++": answer = ++num1; break;
                case "--": answer = --num1; break;
                case "-": answer = num1 - num2; break;
                case "/": answer = num1 / num2; break;
                case "*": answer = num1 * num2; break;
                case "%": answer = num1 % num2; break;
                case "^": answer = Math.Pow(num1, num2); break;
                case "Sqrt": answer = Math.Sqrt(num1); break;
                case "^2": answer = Math.Pow(num1, 2); break;
                case "n": answer = -num1; break;
                default: answer = 0; break;




            }
            return (answer);
        }
    }
}