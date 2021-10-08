using System;

namespace cse210_hilo
{
    class Dealer
    {

        int card;
        int dealCounter = 0;
        public int DealNextCard()
        {
            dealCounter++;
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

<<<<<<< HEAD
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
=======
        public bool IsCorrectGuess(string guess)
        {
            if (guess == "H" & card > lastCard)
            {
                return true;
            }
            else if (guess = "H" & card < lastCard)
            {
                return false;
            }
            else if (guess = "L" & card < lastCard)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
>>>>>>> dfff12c6d2d34d55f4ef4d31415cf7645ad7e83b

        public bool isFirstDeal()
        {
            if (dealCounter == 0)
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
