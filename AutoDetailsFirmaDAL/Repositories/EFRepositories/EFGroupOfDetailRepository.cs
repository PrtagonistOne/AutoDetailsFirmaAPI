using AutoDetailsFirmaDAL.EF;
using AutoDetailsFirmaDAL.Entities;
using AutoDetailsFirmaDAL.Interfaces.EFInterfaces.IEFRepositories;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace AutoDetailsFirmaDAL.Repositories.EFRepositories
{
    public class EFGroupOfDetailRepository : GenericRepository<GroupOfDetail, int>, IEFGroupOfDetailRepository
    {
        private readonly AutoDetailContext _context;
        public EFGroupOfDetailRepository(AutoDetailContext context) : base(context)
        {
        }
        public async Task<IEnumerable<GroupOfDetail>> GetAllGroupOfDetails()
        {
            return await _context.Set<GroupOfDetail>().ToListAsync();
        }
        public async Task<GroupOfDetail> GetAllGroupOfDetailsById(int id)
        {
            return await _context.Set<GroupOfDetail>().FindAsync(id);
        }
        public async Task AddGroupOfDetails(GroupOfDetail entity)
        {
            await _context.AddAsync<GroupOfDetail>(entity);
        }
        public async Task UpdateGroupOfDetails(GroupOfDetail entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        public async Task DeleteGroupOfDetails(int id)
        {
            _context.Entry(id).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }
    }
}
