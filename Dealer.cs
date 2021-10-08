using System;

namespace cse210_hilo
{
    class Dealer
    {

        int card = 0;
        int lastCard;
        int dealCounter = 0;

        
        /// <summary>
        /// Pulls a random number between 1 and 13 and compares it to the last
        /// number to make sure it is different.
        /// </summary>
        /// <returns>Returns a value that could be drawn from a deck.</returns>
        public int DealNextCard()
        {
            dealCounter++;
            Random cardDraw = new Random();
            lastCard = card;
            card = cardDraw.Next(1, 14);
            while (!IsDifferentCard())
            {
                card = cardDraw.Next(1, 14);
            }
            return card;
        }


        /// <summary>
        /// Determines if the card just "drawn" is different than the previous
        /// "drawn" card so that it can be higher or lower.
        /// </summary>
        /// <returns>Returns a boolean value, true if the card is different
        /// and false if it isn't.</returns>
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

        /// <summary>
        /// Determines whether or not it is the first deal of the game.
        /// </summary>
        /// <returns>A boolean value that is true if it is the first deal
        /// and false if it isn't.</returns>
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
