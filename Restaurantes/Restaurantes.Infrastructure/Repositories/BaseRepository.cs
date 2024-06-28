using Microsoft.EntityFrameworkCore;
using Restaurantes.Domain.Entities;
using Restaurantes.Domain.Interfaces;
using Restaurantes.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurantes.Infrastructure.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected readonly AppDbContext _context;

        public BaseRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<T> Create(T entity)
        {
            
            _context.Add(entity);
            await _context.SaveChangesAsync();
            return entity;

        }

        public async Task<T> Delete(T entity)
        {
            _context.Remove(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<T> Get(int? id)
        {
            return await _context.Set<T>().FirstOrDefaultAsync( x => x.Id == id);
        }

     

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

  

        public async Task<T> Update(T entity)
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();

            return entity;
        }
    }
}