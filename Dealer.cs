using System;

namespace cse210_hilo
{
    class Dealer
    {
        int lastCard = 0;
        public void DealNextCard()
        {
            Random cardDraw = new Random();
            bool cardNotSame = false;
            while (cardNotSame)
            {
                card = cardDraw.Next(1, 14);
                
                cardNotSame = IsDifferentCard(card);
            }
            lastCard = card;
        }

        public bool IsDifferentCard(int card)
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
       public bool IsCorrectGuess(guess, currentCard)
       {
           if (guess == H & currentCard > lastCard)
           {
               IsCorrectGuess = true;
           }
           else if(guess = H & currentCard < lastCard)
           {
               IsCorrectGuess = false;
           }
           else if (guess = L & currentCard < lastCard)
           {
               IsCorrectGuess = true;
           }
           else if(guess = L & currentCard > lastCard)
           {
               IsCorrectGuess = false;
           }
       }

       public int AssignPoints()
       {
           int score = 0;

           if (!IsCorrectGuess(currentCard))
           {
               score -= 75;
           }
           else if (IsCorrectGuess(currentCard))
           {
               score += 100;
           }

           return score;
       }
    }
}
