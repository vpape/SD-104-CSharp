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
            Console.WriteLine("Card at position 0: " + theDeck.theCards[0].ToString());
            theDeck.Shuffle();
            Console.WriteLine("Deck has been shuffled. Card at position 0: " + theDeck.theCards[0].ToString());
            Console.ReadLine();

            while (gameOver == false)
            {
                int warPoints = 0;

                Card player1Card = theDeck.Draw(); //output player1Card using card.ToString
                Card player2Card = theDeck.Draw(); //output player2Card using card.ToString


                while (player1Card == player2Card)
                {

                    Console.WriteLine("This is WAR!! ");

                    warPoints += 2;

                    player1Card = theDeck.Draw();
                    player2Card = theDeck.Draw();                    
                    Console.ReadLine();

                                        

                }

                //compare the two cards
                if (player1Card > player2Card)
                {
                    //player1Card wins and gets two points;
                    warPoints += 2;
                    player1points += warPoints;

                    Console.WriteLine("Player 1 Wins: "  + player1Card.ToString());
                    Console.WriteLine("Player 2 Loses: "  + player2Card.ToString());
                    Console.ReadLine();


                }
                
                else if (player2Card > player1Card)
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
                    Console.WriteLine("The War is Over!! ");
                }

                else if (player1points == player2points)
                {
                    Console.WriteLine("It's a tie at this point!! ");
                    Console.WriteLine("Player 1 Total Points: " + player1points);
                    Console.WriteLine("Player 2 Total Points: " + player2points);
                    Console.ReadLine();
                }
            }
            //output the winner based on who has more points
            Console.WriteLine("Player 1 Total Points: " + player1points);
            Console.WriteLine("Player 2 Total Points: " + player2points);
            Console.ReadLine();
        }
    }
}

