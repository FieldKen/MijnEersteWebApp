using MijnEersteWebApp.Domain;

namespace MijnEersteWebApp.Database
{
    public class MovieDatabase : IMovieDatabase
    {
        private int counter = 0;
        private List<Movie> movies;

        public MovieDatabase()
        {
            movies = new List<Movie>();

            Insert(new Movie
            {
                Title = "De smurfen",
                Description = "Blauwe gnomes",
                Genre = "Kids",
                Rating = 8
            });

            Insert(new Movie
            {
                Title = "The Hunger Games",
                Description = "Battle Royale wannabe",
                Genre = "Fantasy",
                Rating = 9
            });

            Insert(new Movie
            {
                Title = "Interstellar",
                Description = "Weird",
                Genre = "Science Fiction",
                Rating = 10
            });
        }

        public Movie Insert(Movie movie)
        {
            movie.Id = counter++;
            movies.Add(movie);
            return movie;
        }

        public Movie GetMovie(int id)
        {
            return movies.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Movie> GetMovies()
        {
            return movies;
        }

        public void Update(int id, Movie updatedMovie)
        {
            var movie = movies.FirstOrDefault(x => x.Id == id);
            if (movie != null)
            {
                movie.Title = updatedMovie.Title;
                movie.Description = updatedMovie.Description;
                movie.Genre = updatedMovie.Genre;
                movie.Rating = updatedMovie.Rating;
            }
        }

        public void Delete(int id)
        {
            var movie = movies.FirstOrDefault(x => x.Id == id);
            if (movie != null)
            {
                movies.Remove(movie);
            }
        }
    }
}
