using eMovieApp.Models;
using eMovieApp.Data;
using eMovieApp.Data.Base;

namespace eMovieApp.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
        public ActorsService(AppDbContext context) : base(context) { }
    }
}