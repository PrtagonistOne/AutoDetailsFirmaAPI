using AutoDetailsFirmaDAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoDetailsFirmaDAL.Interfaces.EFInterfaces.IEFRepositories
{
    public interface IEFDetailRepository : IGenericRepository<Detail, int>
    {
        Task <IEnumerable<Detail>> GetAllDetails();
        Task <Detail> GetAllDetailById(int Id);
        Task AddDetail(Detail entity);
        Task UpdateDetail(Detail entity);
        Task DeleteDetail(Detail entity);
    }
}
