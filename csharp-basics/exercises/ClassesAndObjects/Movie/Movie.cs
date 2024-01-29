using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie
{
    internal class Movie
    {
        public string Title { get; private set; }
        public string Studio { get; private set; }
        public string Rating { get; private set; }

        public Movie(string title,string studio,string rating)
        {
            Title = title;
            Studio = studio;
            Rating = rating;
        }

        public Movie(string title, string studio)
        {
            Title = title;
            Studio = studio;
            Rating="PG";
        }
    }
}
