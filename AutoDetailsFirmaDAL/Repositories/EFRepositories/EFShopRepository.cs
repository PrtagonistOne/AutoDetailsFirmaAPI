using AutoDetailsFirmaDAL.EF;
using AutoDetailsFirmaDAL.Entities;
using AutoDetailsFirmaDAL.Interfaces.EFInterfaces.IEFRepositories;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace AutoDetailsFirmaDAL.Repositories.EFRepositories
{
    public class EFShopRepository : GenericRepository<Shop, int>, IEFShopRepository
    {
        private readonly AutoDetailContext _context;
        public EFShopRepository(AutoDetailContext context) : base(context)
        {
        }
        public async Task<IEnumerable<Shop>> GetAllShops()
        {
            return await _context.Set<Shop>().ToListAsync();
        }
        public async Task<Shop> GetAllShopsById(int id)
        {
            return await _context.Set<Shop>().FindAsync(id);
        }
        public async Task AddShops(Shop entity)
        {
            await _context.AddAsync<Shop>(entity);
        }
        public async Task UpdateShops(Shop entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        public async Task DeleteShops(int id)
        {
            _context.Entry(id).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }
    }
}
