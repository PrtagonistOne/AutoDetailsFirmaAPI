using AutoDetailsFirmaDAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoDetailsFirmaDAL.Interfaces.EFInterfaces.IEFRepositories
{
    public interface IEFDetailRepository : IGenericRepository<Detail, int>
    {
        Task <IEnumerable<Detail>> GetAllDetails();
        Task <Detail> GetAllDetailsById(int Id);
        Task AddDetails(Detail entity);
        Task UpdateDetails(Detail entity);
        Task DeleteDetails(Detail entity);
    }
}
