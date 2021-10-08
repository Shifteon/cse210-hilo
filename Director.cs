using System;

namespace cse210_hilo
{
    /// <summary>
    /// Like a director in a play, this class is responsible for the game, the script,
    /// the actors, and all of their interactions.
    /// 
    /// For this program, it has responsibility for the score, coordinating with the
    /// player to roll, and the sequence of play.
    /// </summary>
    class Director
    {
        bool _keepPlaying = true;
        int _score = 300;
        int firstCard;
        int lastCard;
        string _guess;
        Dealer _dealer = new Dealer();

        public void StartGame()
        {
            while (_keepPlaying)
            {
                DoUpdates();
            }
        }

        void DoUpdates()
        {
            if (_dealer.isFirstDeal())
                firstCard = _dealer.DealNextCard();
            // Show card
            Console.WriteLine($"The card is: {firstCard}");
            // Have them guess
            higherOrLower();
            // Show next card
            lastCard = _dealer.DealNextCard();
            Console.WriteLine($"Next card was: {lastCard}");
            // Decide if they were right or wrong
            AssignPoints();
            // Show score
            Console.WriteLine($"Your score is: {_score}");
            firstCard = lastCard;
            // Enough points? -> play again?
            if (canPlayAgain())
                playAgain();
            else
                _keepPlaying = false;
            Console.WriteLine("");
        }

        bool canPlayAgain()
        {
            return _score > 0;
        }

        void playAgain()
        {
            if (!_dealer.isFirstDeal())
            {
                Console.Write("Keep Playing? [y/n] ");
                string choice = Console.ReadLine();
                _keepPlaying = (choice == "y");
                return;
            }
        }

        void higherOrLower()
        {
            Console.Write("Higher or lower? [h/l] ");
            _guess = Console.ReadLine();
            return;
        }

        public void AssignPoints()
       {
           if (!IsCorrectGuess())
           {
               _score -= 75;
           }
           else if (IsCorrectGuess())
           {
               _score += 100;
           }
       }

       public bool IsCorrectGuess()
       {
        //    if (_guess.ToLower() == "h")
        //    {
        //        if ()
        //    }

           if (_guess.ToLower() == "h" & firstCard < lastCard)
           {
               return true;
           }
           else if (_guess.ToLower() == "h" & firstCard > lastCard)
           {
               return false;
           }
           else if (_guess.ToLower() == "l" & firstCard > lastCard)
           {
               return true;
           }
           else
           {
               return false;
           }
       }

    } // end of class: Director
}
