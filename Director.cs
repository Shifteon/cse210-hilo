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
        int card;
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
            // Show card
            // Have them guess
            // Show next card
            // Decide if they were right or wrong
            // Show score
            // Enough points? -> play again?
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

        public int AssignPoints()
        {
            int score = 0;

            if (IsCorrectGuess())
            {
                score -= 75;
            }
            else if (IsCorrectGuess())
            {
                score += 100;
            }

            return score;
        }

        public bool IsCorrectGuess()
        {
            if (_guess == "H" & card > lastCard)
            {
                return true;
            }
            else if (_guess == "H" & card < lastCard)
            {
                return false;
            }
            else if (_guess == "L" & card < lastCard)
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
