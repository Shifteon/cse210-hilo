using System;

namespace cse210_hilo
{
    /// <summary>
    /// Like a director in a play, this class is responsible for the game, the script,
    /// the actors, and all of their interactions.
    /// </summary>
    class Director
    {
        bool _keepPlaying = true;
        int _score = 300;
        int firstCard;
        int lastCard;
        string _guess;
        Dealer _dealer = new Dealer();

        /// <summary>
        /// Game loop
        ///
        /// Condition: Exits when _keepPlayin == false
        /// </summary>
        public void StartGame()
        {
            while (_keepPlaying)
            {
                DoUpdates();
            }
        }

         /// <summary>
        /// Calls everything in order to run the game
        /// and sets the needed card variables
        /// </summary>
        void DoUpdates()
        {
            // Set card if it is the first turn
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

         /// <summary>
        /// Determines if the player can play again
        /// 
        /// The condition is: if the score > 0
        /// </summary>
        /// <return>A bool telling us if they can play again</return>
        bool canPlayAgain()
        {
            return _score > 0;
        }

         /// <summary>
        /// Asks the player if they want to play again.
        /// Sets _keepPlaying according to their answer.
        /// </summary>
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

         /// <summary>
        /// Asks the user to guess if the next card is higher
        /// or lower. Sets guess to their answer.
        /// </summary>
        void higherOrLower()
        {
            Console.Write("Higher or lower? [h/l] ");
            _guess = Console.ReadLine();
            return;
        }

        
        /// <summary>
        /// Adds or removes points from the score
        /// 
        /// The rules are:
        ///     Correct guess: +100 Points
        ///     Incorrect: -75 Points
        /// </summary>
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

       /// <summary>
        /// Determines if the guess was correct
        /// 
        /// If the guess was higher and the next card was higher, returns true
        /// If the guess was lower and the next card was lower, returns true
        /// Else, returns false
        /// </summary>
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
