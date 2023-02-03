using eMovieApp.Data.Base;
using eMovieApp.Data.ViewModels;
using eMovieApp.Models;
using System.Threading.Tasks;

namespace eMovieApp.Data.Services
{
    public interface IMoviesService : IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
        Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();

        Task AddNewMovieAsync(NewMovieVM data);
    }
}
