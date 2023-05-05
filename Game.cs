using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Jefferson
{
    class Game : IGenre
    {
        //calling the 3 types called Esrb,Genre, and Title.
        public string Esrb { get; set; }
        public string Genre { get; set; }
        public string Title { get; set; }

        //calls upon strings esrbParam,genreParam, and TitleParam
        public Game(string esrbParam, string genreParam, string TitleParam)
        {
            Esrb = esrbParam;
            Genre = genreParam;
            Title = TitleParam;
        }

        //prints to console The title givien in this sentnce ______ is starting! Game ON!
        public void PlayGame()
        {
            Console.WriteLine($"{Title} is starting! Game ON!");
        }

        //retuens the line of code and is called on later in Program.cs
        public string Describe()
        {
            return $"{Title} is a {Genre} game, rated {Esrb}!";
        }
    }
}
