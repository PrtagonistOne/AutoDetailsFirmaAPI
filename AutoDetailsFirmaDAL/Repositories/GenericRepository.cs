using AutoDetailsFirmaDAL.Interfaces;
using AutoDetailsFirmaDAL.Interfaces.EntityInterfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using AutoDetailsFirmaDAL.EF;
using System.Threading.Tasks;

namespace AutoDetailsFirmaDAL.Repositories
{
    public class GenericRepository<TEntity, TId> : IGenericRepository<TEntity, TId> where TEntity : class, IEntity<TId>
    {
        private readonly AutoDetailContext _context;
        protected DbSet<TEntity> _dbSet;
        public GenericRepository(AutoDetailContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }
        public async Task<IEnumerable<TEntity>>GetAll()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }
        public async Task<TEntity> Get(TId TId)
        {
            return await _context.Set<TEntity>().FindAsync(TId);
        }
        public async Task Add(TEntity entity)
        {
            _dbSet.Add(entity);
            await _context.SaveChangesAsync();
        }
        public async Task Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        public async Task Delete(TId id)
        {
            TEntity x = await _dbSet.FindAsync(id);
            _dbSet.Remove(x);
            await _context.SaveChangesAsync();

        }

    }
}
