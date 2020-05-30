using AutoDetailsFirmaDAL.EF;
using AutoDetailsFirmaDAL.Entities;
using AutoDetailsFirmaDAL.Interfaces.EFInterfaces.IEFRepositories;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using AutoDetailsFirmaDAL.Paging;
using Microsoft.EntityFrameworkCore;

namespace AutoDetailsFirmaDAL.Repositories.EFRepositories
{
    public class EFDetailRepository : GenericRepository<Detail, int>, IEFDetailRepository
    {

        public EFDetailRepository(AutoDetailContext context) : base(context)
        {
        }
        public async Task<IEnumerable<Detail>> GetPagedDetails(DetailParameters ownerParameters)
        {
            var details = await _context.Set<Detail>().ToListAsync<Detail>();

            return details
                .OrderBy(on => on.NameOfDetail)
                .Skip((ownerParameters.PageNumber - 1) * ownerParameters.PageSize)
                .Take(ownerParameters.PageSize)
                .ToList();
        }

    }
}
