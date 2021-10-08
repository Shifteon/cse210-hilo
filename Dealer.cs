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
    }
}
