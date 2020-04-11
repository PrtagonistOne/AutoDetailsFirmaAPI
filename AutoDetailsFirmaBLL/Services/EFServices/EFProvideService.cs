using AutoDetailsFirmaDAL.Entities;
using AutoDetailsFirmaDAL.Interfaces;
using AutoDetailsFirmaDAL.Interfaces.EFInterfaces.IEFServices;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoDetailsFirmaBLL.Services.EFServices
{
    public class EFProvideService : IEFProvideService
    {
        IEFUnitOfWork _eFUnitOfWork;
        public EFProvideService(IEFUnitOfWork eFUnitOfWork)
        {
            _eFUnitOfWork = eFUnitOfWork;
        }
        public async Task<IEnumerable<Provide>> GetProvides()
        {
            return await _eFUnitOfWork.EFProvideRepository.GetAll();
        }
        public async Task<Provide> GetByIdProvides(int id)
        {
            return await _eFUnitOfWork.EFProvideRepository.GetAllProvidesById(id);
        }
        public async Task AddProvides(Provide provide)
        {
            await _eFUnitOfWork.EFProvideRepository.AddProvides(provide);
        }
        public async Task UpdateProvides(Provide provide)
        {
            await _eFUnitOfWork.EFProvideRepository.UpdateProvides(provide);
        }
        public async Task DeleteProvides(Provide provide)
        {
            await _eFUnitOfWork.EFProvideRepository.DeleteProvides(provide);
        }
    }
}
