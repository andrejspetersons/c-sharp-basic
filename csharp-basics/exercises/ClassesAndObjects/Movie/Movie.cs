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
        public string title { get; private set; }
        public string studio { get; private set; }
        public string rating { get; private set; }

        public Movie(string title,string studio,string rating)
        {
            this.title = title;
            this.studio = studio;
            this.rating = rating;
        }

        public Movie(string title, string studio)
        {
            this.title = title;
            this.studio = studio;
            rating="PG";
        }
    }
}
