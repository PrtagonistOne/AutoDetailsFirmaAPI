using AutoDetailsFirmaDAL.Interfaces;
using AutoDetailsFirmaDAL.Interfaces.EntityInterfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using AutoDetailsFirmaDAL.EF;
using System.Threading.Tasks;
using System.Linq;
using System.Linq.Expressions;

namespace AutoDetailsFirmaDAL.Repositories
{
    public class GenericRepository<TEntity, TId> : IGenericRepository<TEntity, TId> where TEntity : class, IEntity<TId>
    {
        protected readonly AutoDetailContext _context;
        protected DbSet<TEntity> _dbSet;
        public GenericRepository(AutoDetailContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
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
            _context.Add(entity);
            await _context.SaveChangesAsync();
        }
        public async Task Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        public async Task Delete(TId id)
        {
            _context.Remove(_context.Set<TEntity>().Find(id));
            await _context.SaveChangesAsync();

        }
        public IQueryable<TEntity> FindByCondition(Expression<Func<TEntity, bool>> expression)
        {
            return _dbSet.Where(expression);
        }

    }
}
