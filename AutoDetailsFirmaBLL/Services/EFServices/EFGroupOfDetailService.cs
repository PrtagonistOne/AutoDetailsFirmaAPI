using AutoDetailsFirmaBLL.DTO;
using AutoDetailsFirmaDAL.Entities;
using AutoDetailsFirmaDAL.Interfaces;
using AutoDetailsFirmaDAL.Interfaces.EFInterfaces.IEFServices;
using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoDetailsFirmaBLL.Services.EFServices
{
    public class EFGroupOfDetailService : IEFGroupOfDetailService
    {
        IEFUnitOfWork _eFUnitOfWork;
        private readonly IMapper _mapper;
        public EFGroupOfDetailService(IEFUnitOfWork eFUnitOfWork, IMapper mapper)
        {
            _eFUnitOfWork = eFUnitOfWork;
            _mapper = mapper;
        }
        public async Task<IEnumerable<GroupOfDetailDTO>> GetAllGroupOfDetails()
        {
            var x = await _eFUnitOfWork.EFGroupOfDetailRepository.GetAll();
            List<GroupOfDetailDTO> r = new List<GroupOfDetailDTO>();
            foreach (var key in x)
                r.Add(_mapper.Map<GroupOfDetail, GroupOfDetailDTO>(key));
            return r;
        }
        public async Task<GroupOfDetailDTO> GetGroupOfDetailsById(int id)
        {
            var x = await _eFUnitOfWork.EFGroupOfDetailRepository.Get(id);
            return _mapper.Map<GroupOfDetail, GroupOfDetailDTO>(x);
        }
        public async Task AddGroupOfDetails(GroupOfDetailDTO groupOf)
        {
            var x = _mapper.Map<GroupOfDetailDTO, GroupOfDetail>(groupOf);
            await _eFUnitOfWork.EFGroupOfDetailRepository.Add(x);

        }
        public async Task UpdateGroupOfDetails(GroupOfDetailDTO groupOf)
        {
            var x = _mapper.Map<GroupOfDetailDTO, GroupOfDetail>(groupOf);
            await _eFUnitOfWork.EFGroupOfDetailRepository.Update(x);
        }
        public async Task DeleteGroupOfDetails(int id)
        {
            await _eFUnitOfWork.EFGroupOfDetailRepository.Delete(id);
        }
        public async Task<GroupOfDetailDTO> GetGroupByName(string id)
        {
            var x = await _eFUnitOfWork.EFGroupOfDetailRepository.GetGroupByName(id);
            GroupOfDetailDTO res = _mapper.Map<GroupOfDetail, GroupOfDetailDTO>(x);
            return res;
        }
    }
}
