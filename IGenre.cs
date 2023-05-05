using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Jefferson
{
    //makes an interface called Genre.
    interface IGenre
    {
        //gets and sets vaules for the 3 types Esrb,Genre,and Title.
        public string Esrb { get; set; }

        public string Genre { get; set; }

        public string Title { get; set; }

        //makes a abstract method called Describe.
        public string Describe();
    }
}
