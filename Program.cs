using System;

namespace cse210_hilo
{
    class Program
    {
        /// <summary>
        /// Runs the game by calling an instance of the director class and calling StartGame
        /// </summary>
        static void Main(string[] args)
        {
            Director game = new Director();
            game.StartGame();
        }
    }
}