using AutoDetailsFirmaDAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoDetailsFirmaDAL.Interfaces.EFInterfaces.IEFRepositories
{
    public interface IEFProviderRepository : IGenericRepository<Provider, int>
    {
        Task<IEnumerable<Provider>> GetAllProviders();
        Task<Provider> GetAllProvidersById(int Id);
        Task AddProviders(Provider entity);
        Task UpdateProviders(Provider entity);
        Task DeleteProviders(int id);
    }
}
