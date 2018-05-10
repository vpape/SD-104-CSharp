using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0;
            double num2 = 0;    

            string str = GetInput("Enter Equation: ");
            string[] strArray = str.Split(' ');
            num1 = GetNumber(strArray[0]);
            if (strArray.Length == 3)
                num2 = GetNumber(strArray[2]);         
            double answer = GetAnswer( strArray[1], num1, num2);
            if (strArray.Length == 3)
                Console.WriteLine("{0:F2} = {1:F2} {2:F2} {3:F2}", answer, num1, strArray[1], num2);
            else
                Console.WriteLine("{0:F2} = {1:F2} {2:F2}", answer, num1, strArray[1]);


            Console.WriteLine("{0} = {1} {2} {3}", answer, num1, strArray[1], num2);                 
            Console.ReadLine();
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
                case "^2": answer = Math.Pow(num1,2); break;
                case "n": answer = -num1; break;
                default: answer = 0;            break;

                 


            }
            return (answer);
        }
    }
}
