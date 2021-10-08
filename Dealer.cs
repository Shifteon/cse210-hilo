using System;

namespace cse210_hilo
{
    class Dealer
    {
        int lastCard = 0;
        int card;
        public int DealNextCard()
        {
            Random cardDraw = new Random();
            card = cardDraw.Next(1, 14);
            while (IsDifferentCard())
            {
                card = cardDraw.Next(1, 14);
            }
            lastCard = card;
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
        
       public bool IsCorrectGuess(string guess)
       {
           if (guess == H & card > lastCard)
           {
               return true;
           }
           else if(guess = H & card < lastCard)
           {
               return false;
           }
           else if (guess = L & card < lastCard)
           {
               return true;
           }
           else
           {
               return false;
           }
       }

       public int AssignPoints()
       {
           int score = 0;

           if (!IsCorrectGuess())
           {
               score -= 75;
           }
           else if (IsCorrectGuess())
           {
               score += 100;
           }

           return score;
       }
    }
}
