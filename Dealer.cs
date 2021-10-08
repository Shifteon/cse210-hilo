using System;

namespace cse210_hilo
{
    class Dealer
    {
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
    }
}
