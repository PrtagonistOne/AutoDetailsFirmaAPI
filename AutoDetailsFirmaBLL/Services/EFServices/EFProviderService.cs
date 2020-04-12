using AutoDetailsFirmaBLL.DTO;
using AutoDetailsFirmaDAL.Entities;
using AutoDetailsFirmaDAL.Interfaces;
using AutoDetailsFirmaDAL.Interfaces.EFInterfaces.IEFServices;
using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoDetailsFirmaBLL.Services.EFServices
{
    public class EFProviderService : IEFProviderService
    {
        IEFUnitOfWork _eFUnitOfWork;
        private readonly IMapper _mapper;
        public EFProviderService(IEFUnitOfWork eFUnitOfWork, IMapper mapper)
        {
            _eFUnitOfWork = eFUnitOfWork;
            _mapper = mapper;
        }
        public async Task<IEnumerable<ProviderDTO>> GetProviders()
        {
            var x = await _eFUnitOfWork.EFProviderRepository.GetAllProviders();
            List<ProviderDTO> r = new List<ProviderDTO>();
            foreach (var key in x)
                r.Add(_mapper.Map<Provider, ProviderDTO>(key));
            return r;
        }
        public async Task<ProviderDTO> GetProviders(int id)
        {
            var x = await _eFUnitOfWork.EFProviderRepository.GetAllProvidersById(id);
            return _mapper.Map<Provider, ProviderDTO>(x);
        }
        public async Task AddProviders(ProviderDTO provider)
        {
            var x = _mapper.Map<ProviderDTO, Provider>(provider);
            await _eFUnitOfWork.EFProviderRepository.AddProviders(x);
        }
        public async Task UpdateProviders(ProviderDTO provider)
        {
            var x = _mapper.Map<ProviderDTO, Provider>(provider);
            await _eFUnitOfWork.EFProviderRepository.UpdateProviders(x);
        }
        public async Task DeleteProviders(int id)
        {
            await _eFUnitOfWork.EFProviderRepository.DeleteProviders(id);
        }
    }
}
