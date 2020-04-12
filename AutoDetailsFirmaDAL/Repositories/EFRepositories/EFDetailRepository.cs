using AutoDetailsFirmaDAL.EF;
using AutoDetailsFirmaDAL.Entities;
using AutoDetailsFirmaDAL.Interfaces.EFInterfaces.IEFRepositories;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace AutoDetailsFirmaDAL.Repositories.EFRepositories
{
    public class EFDetailRepository : GenericRepository<Detail, int>, IEFDetailRepository
    {
        private readonly AutoDetailContext _context;
        public EFDetailRepository(AutoDetailContext context) : base(context)
        {
        }
        public async Task<IEnumerable<Detail>> GetAllDetails()
        {
            return await _context.Set<Detail>().ToListAsync();
        }
        public async Task<Detail> GetAllDetailsById(int id)
        {
            return await _context.Set<Detail>().FindAsync(id);
        }
        public async Task AddDetails(Detail entity)
        {
            await _context.AddAsync<Detail>(entity);
        }
        public async Task UpdateDetails(Detail entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        public async Task DeleteDetails(int id)
        {
            _context.Entry(id).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }
    }
}
