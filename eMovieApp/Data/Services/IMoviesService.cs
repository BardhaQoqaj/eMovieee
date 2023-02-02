using eMovieApp.Data.Base;
using eMovieApp.Models;

namespace eMovieApp.Data.Services
{
    public interface IMoviesService : IEntityBaseRepository<Movie>
    {
    }
}
