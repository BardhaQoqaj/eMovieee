using eMovieApp.Models;
using eMovieApp.Data;
using eTickets.Data.Base;

namespace eTickets.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
        public ActorsService(AppDbContext context) : base(context) { }
    }
}