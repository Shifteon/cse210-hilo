using System;

namespace cse210_hilo
{
    class Dealer
    {

        int card = 0;
        int lastCard;
        int dealCounter = 0;
        public int DealNextCard()
        {
            dealCounter++;
            Random cardDraw = new Random();
            lastCard = card;
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
