using AutoDetailsFirmaDAL.EF;
using AutoDetailsFirmaDAL.Entities;
using AutoDetailsFirmaDAL.Interfaces.EFInterfaces.IEFRepositories;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Linq;
using System.Data.Entity;

namespace AutoDetailsFirmaDAL.Repositories.EFRepositories
{
    public class EFGroupOfDetailRepository : GenericRepository<GroupOfDetail, int>, IEFGroupOfDetailRepository
    {
        public EFGroupOfDetailRepository(AutoDetailContext context) : base(context)
        {
        }

        public async Task<GroupOfDetail> GetGroupByName(string articleOfGroupOfDetail)
        {
            var details = await _context.Set<GroupOfDetail>().ToListAsync<GroupOfDetail>();

            return details.Where(details => details.ArticleOfGroupOfDetail == articleOfGroupOfDetail).FirstOrDefault();

        }
    }
}
