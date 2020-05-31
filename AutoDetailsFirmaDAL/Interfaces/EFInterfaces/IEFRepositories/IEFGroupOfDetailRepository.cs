using AutoDetailsFirmaDAL.Entities;
using AutoDetailsFirmaDAL.Paging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoDetailsFirmaDAL.Interfaces.EFInterfaces.IEFRepositories
{
    public interface IEFGroupOfDetailRepository  : IGenericRepository<GroupOfDetail, int>
    {
        Task<PagedList<GroupOfDetail>> GetPagedGroupOfDetails(GroupOfDetailParameters parameters);
    }
}
