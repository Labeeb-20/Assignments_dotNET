
namespace MVCModelViewAssignment.Models
{
    public class MovieDataAccess : IMovieDataAccess
    {
        public readonly MovieDBContext dbContext;
        public MovieDataAccess(MovieDBContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void AddMovie(Movie movie)
        {
            dbContext.Movie.Add(movie);
            dbContext.SaveChanges();
        }

        public List<Movie> GetMovies()
        {
            return dbContext.Movie.ToList();
        }
    }
}
