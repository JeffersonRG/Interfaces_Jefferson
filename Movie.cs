using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Jefferson
{
    class Movie : IGenre
    {
        public string Esrb { get; set; }
        public string Genre { get; set; }
        public string Title { get; set; }

        public Movie(string esrbParam, string genreParam, string TitleParam)
        {
            Esrb = esrbParam;
            Genre = genreParam;
            Title = TitleParam;
        }

        public void PlayMovie()
        {
            Console.WriteLine($"{Title} is starting SSsssshhhhh!");
        }

        public string Describe()
        {
            return $"{Title} is a {Genre} movie, rated {Esrb}!";
        }
    }
}
