using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Jefferson
{
    class Game : IGenre
    {
        public string Esrb { get; set; }
        public string Genre { get; set; }
        public string Title { get; set; }

        public Game(string esrbParam, string genreParam, string TitleParam)
        {
            Esrb = esrbParam;
            Genre = genreParam;
            Title = TitleParam;
        }

        public void PlayGame()
        {
            Console.WriteLine($"{Title} is starting! Game ON!");
        }

        public string Describe()
        {
            return $"{Title} is a {Genre} game, rated {Esrb}!";
        }
    }
}
