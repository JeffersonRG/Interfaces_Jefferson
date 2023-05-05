using System;

namespace Interfaces_Jefferson
{
    class Program
    {
        static void Main(string[] args)
        {
            //creates a new game object called myGame with a vaule of E, FPS, Zombcube.
            Game myGame = new Game("E", "FPS", "Zombcube");
            //calls and prints out myGame.Describe from Game.cs class
            Console.WriteLine(myGame.Describe());
            //calls the method PlayGame from the Game.cs class
            myGame.PlayGame();

            //creates a new movie object called myMovie with a vaule of PG, Adventure/Comedy, Sonic the Hedgehog 2
            Movie myMovie = new Movie("PG", "Adventure/Comedy", "Sonic the Hedgehog 2");
            //calls and prints out myMovie.Describe from Movie.cs class
            Console.WriteLine(myMovie.Describe());
            //calls the method PlayMovie from the Movie.cs class
            myMovie.PlayMovie();
        }
    }
}
