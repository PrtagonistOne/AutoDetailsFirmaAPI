using AutoDetailsFirmaDAL.Entities;
using AutoDetailsFirmaDAL.Interfaces;
using AutoDetailsFirmaDAL.Interfaces.EFInterfaces.IEFServices;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoDetailsFirmaBLL.Services.EFServices
{
    public class EFGroupOfDetailService : IEFGroupOfDetailService
    {
        IEFUnitOfWork _eFUnitOfWork;
        public EFGroupOfDetailService(IEFUnitOfWork eFUnitOfWork)
        {
            _eFUnitOfWork = eFUnitOfWork;
        }
        public async Task<IEnumerable<GroupOfDetail>> GetAllGroupOfDetails()
        {
            return await _eFUnitOfWork.EFGroupOfDetailRepository.GetAllGroupOfDetails();
        }
        public async Task<GroupOfDetail> GetGroupOfDetailsById(int id)
        {
            return await _eFUnitOfWork.EFGroupOfDetailRepository.GetAllGroupOfDetailsById(id);
        }
        public async Task AddGroupOfDetails(GroupOfDetail groupOf)
        {
            await _eFUnitOfWork.EFGroupOfDetailRepository.AddGroupOfDetails(groupOf);
        }
        public async Task UpdateGroupOfDetails(GroupOfDetail groupOf)
        {
            await _eFUnitOfWork.EFGroupOfDetailRepository.UpdateGroupOfDetails(groupOf);
        }
        public async Task DeleteGroupOfDetails(GroupOfDetail groupOf)
        {
            await _eFUnitOfWork.EFGroupOfDetailRepository.DeleteGroupOfDetails(groupOf);
        }
    }
}
