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
        int _score = 0;
        string _guess;
        Dealer _dealer = new Dealer();

        public void StartGame()
        {
            while (_keepPlaying)
            {
                DoUpdates();
                DoOutputs();
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

        void DoOutputs()
        {
            

            if (!_dealer.CanThrow())
            {
                Console.WriteLine("Game Over");
                _keepPlaying = false;
            }
        }

        bool canPlayAgain()
        {
            return _score > 0;
        }

        void playAgain()
        {
            Console.Write("Keep Playing? [y/n] ");
            string choice = Console.ReadLine();
            _keepPlaying = (choice == "y");
            return;
        }

        void higherOrLower()
        {
            Console.Write("Higher or lower? [h/l] ");
            _guess = Console.ReadLine();
            return;
        }

    } // end of class: Director
}
