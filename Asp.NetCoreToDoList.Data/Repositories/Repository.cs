using Asp.NetCoreToDoList.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Asp.NetCoreToDoList.Data.Repositories
{
   
    class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        public readonly DbContext _context;
        public readonly DbSet<TEntity> _dbset;
        public Repository(DbContext context)
        {
            _context = context;
            _dbset = context.Set<TEntity>();
        }
        public async Task AddAsync(TEntity entity)
        {
            await _dbset.AddAsync(entity);
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _dbset.ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _dbset.FindAsync(id);
        }

        public void Remove(TEntity entity)
        {
            _dbset.Remove(entity);
        }

        public TEntity Update(TEntity entity)
        {
            
            _context.Entry(entity).State = EntityState.Modified;
            return entity;
        }
    }
}
