using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            String strPlayerName = "Nolan Ryan";
            double nHits= 2, nAtBats= 5;
            

            Console.WriteLine("This program calculates a baseball player's batting average");
            Console.WriteLine("Player Name:" + " " + strPlayerName);
            Console.WriteLine("Enter Player Name:");
            strPlayerName = Console.ReadLine();
            
            Console.WriteLine("Enter of Hits:");
            nHits = Int32.Parse(Console.ReadLine());
                     
            Console.WriteLine("Enter Number of Bats:");
            nAtBats =  Int32.Parse(Console.ReadLine());

            double dblBattingAverage = nHits / nAtBats;
            Console.WriteLine(strPlayerName);
            Console.WriteLine(nHits + " hits, " + nAtBats + " bats" );
            Console.WriteLine("Batting Avg:" + dblBattingAverage);
            Console.Read();
            
            
            

        }
    }
}