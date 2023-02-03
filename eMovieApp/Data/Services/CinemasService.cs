using eMovieApp.Data.Base;
using eMovieApp.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace eMovieApp.Data.Services
{
    public class CinemasService : EntityBaseRepository<Cinema>, ICinemasService
    {
        public CinemasService(AppDbContext context) : base(context)
        {
        }

        public Task AddAsync(Cinema entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Cinema>> GetAllAsync(params Expression<Func<Cinema, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public Task<Cinema> GetByIdAsync(int id, params Expression<Func<Cinema, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(int id, Cinema entity)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Cinema>> IEntityBaseRepository<Cinema>.GetAllAsync()
        {
            throw new NotImplementedException();
        }

        Task<Cinema> IEntityBaseRepository<Cinema>.GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}

