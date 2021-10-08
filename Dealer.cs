using System;

namespace cse210_hilo
{
    class Dealer
    {

        int card;
        public int DealNextCard()
        {
            Random cardDraw = new Random();
            card = cardDraw.Next(1, 14);
            while (IsDifferentCard())
            {
                card = cardDraw.Next(1, 14);
            }
            return card;
        }

        public bool IsDifferentCard()
        {
            if (card == lastCard)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void DisplayCard()
        {
            Console.WriteLine($"The card is: {card}");
        }

       public bool IsCorrectGuess(string guess)
       {
           if (guess == "H" & card > lastCard)
           {
               return true;
           }
           else if (guess == "H" & card < lastCard)
           {
               return false;
           }
           else if (guess == "L" & card < lastCard)
           {
               return true;
           }
           else
           {
               return false;
           }

       }
    }
}
