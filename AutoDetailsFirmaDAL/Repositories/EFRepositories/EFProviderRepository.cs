using AutoDetailsFirmaDAL.EF;
using AutoDetailsFirmaDAL.Entities;
using AutoDetailsFirmaDAL.Interfaces.EFInterfaces.IEFRepositories;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace AutoDetailsFirmaDAL.Repositories.EFRepositories
{
    public class EFProviderRepository : GenericRepository<Provider, int>, IEFProviderRepository
    {
        private readonly AutoDetailContext _context;
        public EFProviderRepository(AutoDetailContext context) : base(context)
        {
        }
        public async Task<IEnumerable<Provider>> GetAllProviders()
        {
            return await _context.Set<Provider>().ToListAsync();
        }
        public async Task<Provider> GetAllProvidersById(int id)
        {
            return await _context.Set<Provider>().FindAsync(id);
        }
        public async Task AddProviders(Provider entity)
        {
            await _context.AddAsync<Provider>(entity);
        }
        public async Task UpdateProviders(Provider entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        public async Task DeleteProviders(Provider entity)
        {
            _context.Entry(entity).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }
    }
}
