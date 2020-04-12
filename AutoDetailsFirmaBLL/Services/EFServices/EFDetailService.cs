using AutoDetailsFirmaDAL.Entities;
using AutoDetailsFirmaDAL.Interfaces;
using AutoDetailsFirmaDAL.Interfaces.EFInterfaces.IEFServices;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoDetailsFirmaBLL.Services.EFServices
{
    public class EFDetailService : IEFDetailService
    {
        IEFUnitOfWork _eFUnitOfWork;
        public EFDetailService(IEFUnitOfWork eFUnitOfWork)
        {
            _eFUnitOfWork = eFUnitOfWork;
        }
        public async Task<IEnumerable<Detail>> GetAllDetails()
        {
            return await _eFUnitOfWork.EFDetailRepository.GetAll();
        }
        public async Task<Detail> GetDetailsById(int id)
        {
            return await _eFUnitOfWork.EFDetailRepository.GetAllDetailsById(id);
        }
        public async Task AddDetails(Detail detail)
        {
            await _eFUnitOfWork.EFDetailRepository.AddDetails(detail);
        }
        public async Task UpdateDetails(Detail detail)
        {
            await _eFUnitOfWork.EFDetailRepository.UpdateDetails(detail);
        }
        public async Task DeleteDetails(Detail detail)
        {
            await _eFUnitOfWork.EFDetailRepository.DeleteDetails(detail);
        }


    }
}
