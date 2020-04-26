using AutoDetailsFirmaDAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoDetailsFirmaDAL.Interfaces.EFInterfaces.IEFRepositories
{
    public interface IEFGroupOfDetailRepository  : IGenericRepository<GroupOfDetail, int>
    {
        Task<GroupOfDetail> GetGroupByName(string articleOfDetail);
    }
}
