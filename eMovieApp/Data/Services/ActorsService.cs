using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMovieApp.Models;
using Microsoft.EntityFrameworkCore;

namespace eMovieApp.Data.Services
{
    public class ActorsService:IActorsService
    {
        private readonly AppDbContext _context;

        public ActorsService(AppDbContext context)
        {
            _context = context;
        }
    public async Task<IEnumerable<Actor>> GetAll()
    {
        var result =await _context.Actors.ToListAsync();
        return result;
    }

        public async Task<Actor>GetByIdAsync(int id)
        {
            var result = await _context.Actors.FirstOrDefaultAsync(n=> n.Id==id);
            return result;
        }

        public async Task<AddAsync>(Actor actor)
        {
           await  _context.Actors.AddAsync(actor);
            await _context.SaveChangesAsync();
        }

        public Actor Update(int id, Actor newActor)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
