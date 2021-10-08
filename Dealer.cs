using System;

namespace cse210_hilo
{
    class Dealer
    {
<<<<<<< HEAD
        int previousCard = 0;
        public int DealNextCard()
        {
            Random cardDraw = new Random();
            int card;
            bool cardNotSame = false;
            while (cardNotSame);
            {
                card = cardDraw.Next(1, 14);
                
                cardNotSame = IsDifferentCard(card, previousCard);

                
            }
            previousCard = card;
            return card;
        }

        public bool IsDifferentCard(int card, int previoiusCard)
        {
            if (card == previoiusCard)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
=======
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
>>>>>>> 7e47e4c1c93748385757f77428aa7c522db49dfe
    }
}
