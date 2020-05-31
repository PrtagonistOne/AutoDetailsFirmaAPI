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
        public IQueryable<Detail> FindAll()
        {
            return _context.Set<Detail>();
        }
        public async Task<PagedList<Detail>> GetPagedDetails(DetailParameters ownerParameters)
        {
            return await PagedList<Detail>.ToPagedList(FindAll().OrderBy(on => on.Id),
        ownerParameters.PageNumber,
        ownerParameters.PageSize);
        }

    }
}
