using AutoDetailsFirmaDAL.Entities;
using AutoDetailsFirmaDAL.Interfaces;
using AutoDetailsFirmaDAL.Interfaces.EFInterfaces.IEFServices;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoDetailsFirmaBLL.Services.EFServices
{
    public class EFProviderService : IEFProviderService
    {
        IEFUnitOfWork _eFUnitOfWork;
        public EFProviderService(IEFUnitOfWork eFUnitOfWork)
        {
            _eFUnitOfWork = eFUnitOfWork;
        }
        public async Task<IEnumerable<Provider>> GetProviders()
        {
            return await _eFUnitOfWork.EFProviderRepository.GetAllProviders();
        }
        public async Task<Provider> GetProviders(int id)
        {
            return await _eFUnitOfWork.EFProviderRepository.GetAllProvidersById(id);
        }
        public async Task AddProviders(Provider provider)
        {
            await _eFUnitOfWork.EFProviderRepository.AddProviders(provider);
        }
        public async Task UpdateProviders(Provider provider)
        {
            await _eFUnitOfWork.EFProviderRepository.UpdateProviders(provider);
        }
        public async Task DeleteProviders(Provider provider)
        {
            await _eFUnitOfWork.EFProviderRepository.DeleteProviders(provider);
        }
    }
}
