using System;

namespace War
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck theDeck = new Deck();
            int player1points = 0;
            int player2points = 0;
            bool gameOver = false;
            theDeck.Shuffle();

            while (gameOver == false)
            {
                int warPoints = 0;

                Card player1Card = theDeck.Draw(); //output player1Card using card.ToString
                Card player2Card = theDeck.Draw(); //output player2Card using card.ToString


                while (player1Card.isEqual(player2Card))
                {
                    warPoints += 2;

                    player1Card = theDeck.Draw();
                    player2Card = theDeck.Draw();
                                        

                }

                //compare the two cards
                if (player1Card.GreaterThan(player2Card))
                {
                    //player1Card wins and gets two points;
                    warPoints += 2;
                    player1points += warPoints;

                    Console.WriteLine("Player 1 Wins: "  + player1Card.ToString());
                    Console.WriteLine("Player 2 Loses: "  + player2Card.ToString());
                    Console.ReadLine();


                }
                
                else if (player2Card.GreaterThan(player1Card))
                {
                    //player2Card wins and gets two points;
                    warPoints += 2;
                    player2points += warPoints;
                    Console.WriteLine("Player 1 Loses: "  + player1Card.ToString());
                    Console.WriteLine("Player 2 Wins:  " + player2Card.ToString());
                    Console.ReadLine();
                }

                if (theDeck.theCards.Count == 0)
                {
                    gameOver = true;
                }
            }
            //output the winner based on who has more points
            Console.WriteLine("Player 1 Total Points: " + player1points);
            Console.WriteLine("Player 2 Total Points: " + player2points);
            Console.ReadLine();
        }
    }
}

