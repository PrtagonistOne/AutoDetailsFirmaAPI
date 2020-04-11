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
        public GenericRepository(AutoDetailContext context)
        {
            _context = context;
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
            await _context.AddAsync<TEntity>(entity);
        }
        public async Task Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        public async Task Delete(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }

    }
}
