using eMovieApp.Data.Base;
using eMovieApp.Models;

namespace eMovieApp.Data.Services
{
    public class CinemasService : EntityBaseRepository<Producer>, ICinemasService
    {
        public CinemasService(AppDbContext context) : base(context)
        {
        }
    }
}

