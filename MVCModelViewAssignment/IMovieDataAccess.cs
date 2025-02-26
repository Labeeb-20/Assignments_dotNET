using MVCModelViewAssignment.Models;

namespace MVCModelViewAssignment
{
    public interface IMovieDataAccess
    {
        public void AddMovie(Movie movie);
        public List<Movie> GetMovies();
    }
}
