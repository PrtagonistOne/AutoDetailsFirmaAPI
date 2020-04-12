using AutoDetailsFirmaDAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoDetailsFirmaDAL.Interfaces.EFInterfaces.IEFRepositories
{
    public interface IEFGroupOfDetailRepository  : IGenericRepository<GroupOfDetail, int>
    {
        Task <IEnumerable<GroupOfDetail>> GetAllGroupOfDetails();
        Task<GroupOfDetail> GetAllGroupOfDetailsById(int Id);
        Task AddGroupOfDetails(GroupOfDetail entity);
        Task UpdateGroupOfDetails(GroupOfDetail entity);
        Task DeleteGroupOfDetails(int id);
    }
}
