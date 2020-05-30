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
    public class EFProvideService : IEFProvideService
    {
        IEFUnitOfWork _eFUnitOfWork;
        private readonly IMapper _mapper;
        public EFProvideService(IEFUnitOfWork eFUnitOfWork, IMapper mapper)
        {
            _eFUnitOfWork = eFUnitOfWork;
            _mapper = mapper;
        }
        public async Task<IEnumerable<ProvideDTO>> GetProvides()
        {
            var x = await _eFUnitOfWork.EFProvideRepository.GetAll();
            List<ProvideDTO> r = new List<ProvideDTO>();
            foreach (var key in x)
                r.Add(_mapper.Map<Provide, ProvideDTO>(key));
            return r;
        }
        public async Task<ProvideDTO> GetByIdProvides(int id)
        {
            var x = await _eFUnitOfWork.EFProvideRepository.Get(id);
            return _mapper.Map<Provide, ProvideDTO>(x);

        }
        public async Task<string> AddProvides(ProvideDTO provide)
        {
            var x = _mapper.Map<ProvideDTO, Provide>(provide);

            ProvideValidator validator = new ProvideValidator();

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
                await _eFUnitOfWork.EFProvideRepository.Add(x);
                return "Поставка успішно добавлено!";
            }
        }
        public async Task UpdateProvides(ProvideDTO provide)
        {
            var x = _mapper.Map<ProvideDTO, Provide>(provide);
            await _eFUnitOfWork.EFProvideRepository.Update(x);
        }
        public async Task DeleteProvides(int id)
        {
            await _eFUnitOfWork.EFProvideRepository.Delete(id);
        }
    }
}
