using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double nHits= 2, nAtBats= 5;
            

            Console.WriteLine("This program calculates a baseball player's batting average");
            Console.WriteLine("Player Name: ");
            

            String strPlayerName = Console.ReadLine();

            Console.Write("Enter Player 2: ");

            String player2 = Console.ReadLine();

            if ((strPlayerName == "Vernon" || player2 == "Vernon") || 
                (strPlayerName == "Matt" || player2 == "Matt"))
            {
                Console.WriteLine("Nah bro, give me someone else");
                strPlayerName = Console.ReadLine();
            }
            else if(strPlayerName == "Nader")
            {
                Console.WriteLine("Yeah he's a cool guy");
            }
            else
            {
                Console.WriteLine("Thanks for not giving me Vernon or Matt");
            }

            Console.WriteLine("Enter Player Name:");
            strPlayerName = Console.ReadLine();
            
            Console.WriteLine("Enter of Hits:");
            nHits = Int32.Parse(Console.ReadLine());
                     
            Console.WriteLine("Enter Number of Bats:");
            nAtBats =  Int32.Parse(Console.ReadLine());

            double dblBattingAverage = nHits / nAtBats;

            Console.WriteLine();
            Console.WriteLine(strPlayerName);
            Console.WriteLine(nHits + " hits, " + nAtBats + " bats" );
            Console.WriteLine("Batting Avg: " + dblBattingAverage);
            Console.Read();
            


            
            

        }
    }
}