using AutoDetailsFirmaBLL.DTO;
using AutoDetailsFirmaBLL.Validation;
using AutoDetailsFirmaDAL.Entities;
using AutoDetailsFirmaDAL.Interfaces;
using AutoDetailsFirmaDAL.Interfaces.EFInterfaces.IEFServices;
using AutoMapper;
using FluentValidation.Results;
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
            var x = await _eFUnitOfWork.EFProviderRepository.GetAll();
            List<ProviderDTO> r = new List<ProviderDTO>();
            foreach (var key in x)
                r.Add(_mapper.Map<Provider, ProviderDTO>(key));
            return r;
        }
        public async Task<ProviderDTO> GetProvidersById(int id)
        {
            var x = await _eFUnitOfWork.EFProviderRepository.Get(id);
            return _mapper.Map<Provider, ProviderDTO>(x);
        }
        public async Task<string> AddProviders(ProviderDTO provider)
        {
            var x = _mapper.Map<ProviderDTO, Provider>(provider);

            ProviderValidator validator = new ProviderValidator();

            ValidationResult results = validator.Validate(x);
            if (!results.IsValid)
            {
                foreach (var failure in results.Errors)
                {
                    string error = ("Property " + failure.PropertyName + " failed validation. Error was: " + failure.ErrorMessage);
                    return error;
                }
                return "Error";
            }
            else
            {
                await _eFUnitOfWork.EFProviderRepository.Add(x);
                return "Постачальника успішно добавлено!";
            }
        }
        public async Task UpdateProviders(ProviderDTO provider)
        {
            var x = _mapper.Map<ProviderDTO, Provider>(provider);
            await _eFUnitOfWork.EFProviderRepository.Update(x);
        }
        public async Task DeleteProviders(int id)
        {
            await _eFUnitOfWork.EFProviderRepository.Delete(id);
        }
    }
}
