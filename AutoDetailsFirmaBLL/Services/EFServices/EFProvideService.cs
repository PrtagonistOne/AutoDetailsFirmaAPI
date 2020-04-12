using AutoDetailsFirmaBLL.DTO;
using AutoDetailsFirmaDAL.Entities;
using AutoDetailsFirmaDAL.Interfaces;
using AutoDetailsFirmaDAL.Interfaces.EFInterfaces.IEFServices;
using AutoMapper;
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
            var x = await _eFUnitOfWork.EFProvideRepository.GetAllProvidesById(id);
            return _mapper.Map<Provide, ProvideDTO>(x);

        }
        public async Task AddProvides(ProvideDTO provide)
        {
            var x = _mapper.Map<ProvideDTO, Provide>(provide);
            await _eFUnitOfWork.EFProvideRepository.AddProvides(x);
        }
        public async Task UpdateProvides(ProvideDTO provide)
        {
            var x = _mapper.Map<ProvideDTO, Provide>(provide);
            await _eFUnitOfWork.EFProvideRepository.UpdateProvides(x);
        }
        public async Task DeleteProvides(int id)
        {
            await _eFUnitOfWork.EFProvideRepository.DeleteProvides(id);
        }
    }
}
