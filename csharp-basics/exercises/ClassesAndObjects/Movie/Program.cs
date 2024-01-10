namespace Movie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Movie[] movies =
            {
                new Movie("Casino Royale","Eon Productions","PG13"),
                new Movie("Glass","Buena Vista International","PG13"),
                new Movie("Spider-Man: Into the Spider-Verse","Columbia Pictures"),
            };

            Movie[] result = GetPG(movies);
            Console.WriteLine(string.Join(",",result.Select(movie=>$"{movie.title},{movie.studio},{movie.rating}")));
        }

        public static Movie[] GetPG(Movie[] movies)
        {
            List<Movie> movieList = new List<Movie>();

            for (int i = 0; i < movies.Length; i++)
            {
                if (movies[i].rating == "PG")
                {
                    movieList.Add(movies[i]);
                }
            }

            if (movieList.Count == 0)
            {
                return Array.Empty<Movie>();
            }

            return movieList.ToArray();
        }
    }
}