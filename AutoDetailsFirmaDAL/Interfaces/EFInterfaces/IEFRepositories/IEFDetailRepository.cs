using AutoDetailsFirmaDAL.Entities;
using AutoDetailsFirmaDAL.Paging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoDetailsFirmaDAL.Interfaces.EFInterfaces.IEFRepositories
{
    public interface IEFDetailRepository : IGenericRepository<Detail, int>
    {
        Task<IEnumerable<Detail>> GetPagedDetails(DetailParameters ownerParameters);
    }
}
