using System;

namespace cse210_hilo
{
    class Dealer
    {
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
