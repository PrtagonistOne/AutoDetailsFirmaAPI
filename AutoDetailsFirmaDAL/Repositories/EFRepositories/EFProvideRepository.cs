using AutoDetailsFirmaDAL.EF;
using AutoDetailsFirmaDAL.Entities;
using AutoDetailsFirmaDAL.Interfaces.EFInterfaces.IEFRepositories;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace AutoDetailsFirmaDAL.Repositories.EFRepositories
{
    public class EFProvideRepository : GenericRepository<Provide, int>, IEFProvideRepository
    {
        private readonly AutoDetailContext _context;
        public EFProvideRepository(AutoDetailContext context) : base(context)
        {
        }
        public async Task<IEnumerable<Provide>> GetAllProvides()
        {
            return await _context.Set<Provide>().ToListAsync();
        }
        public async Task<Provide> GetAllProvidesById(int id)
        {
            return await _context.Set<Provide>().FindAsync(id);
        }
        public async Task AddProvides(Provide entity)
        {
            await _context.AddAsync<Provide>(entity);
        }
        public async Task UpdateProvides(Provide entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        public async Task DeleteProvides(Provide entity)
        {
            _context.Entry(entity).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }
    }
}
