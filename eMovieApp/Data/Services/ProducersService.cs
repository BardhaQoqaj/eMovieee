using eMovieApp.Data.Base;
using eMovieApp.Models;

namespace eMovieApp.Data.Services
{
    public class ProducersService : EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService(AppDbContext context) : base(context)
        {
        }
    }
}
