using eMovieApp.Data.Base;
using eMovieApp.Models;

namespace eMovieApp.Data.Services
{
    public class MoviesService : EntityBaseRepository<Movie>, IMoviesService
    {
        public MoviesService(AppDbContext context) : base(context)
        {
        }
    }
}
