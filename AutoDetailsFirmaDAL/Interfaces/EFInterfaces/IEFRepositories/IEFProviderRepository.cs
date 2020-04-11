using AutoDetailsFirmaDAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoDetailsFirmaDAL.Interfaces.EFInterfaces.IEFRepositories
{
    public interface IEFProviderRepository : IGenericRepository<Provider, int>
    {
        Task<IEnumerable<Detail>> GetAllProviders();
        Task<Detail> GetAllProvidersById(int Id);
        Task AddProviders(Detail entity);
        Task UpdateProviders(Detail entity);
        Task DeleteProviders(Detail entity);
    }
}
