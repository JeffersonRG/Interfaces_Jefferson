using System;

namespace Interfaces_Jefferson
{
    class Program
    {
        static void Main(string[] args)
        {
            Game myGame = new Game("E", "FPS", "Zombcube");
            Console.WriteLine(myGame.Describe());
            myGame.PlayGame();

            Movie myMovie = new Movie("PG", "Adventure/Comedy", "Sonic the Hedgehog 2");
            Console.WriteLine(myGame.Describe());
            myGame.PlayGame();
        }
    }
}
